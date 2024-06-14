using iCanteen.views;
using iCantina.controllers;
using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iCanteen.controllers
{
	public class ListReservationsController : Controller
	{
		public ListReservationsController() : base()
		{
		}

		public List<Client> GetClients(string term="")
		{
			List<Client> clientsList = new List<Client>();
			if (term != "")
			{
				clientsList.AddRange(context.Users.OfType<Professor>().Where(p => p.Name.Contains(term) || p.NIF.Contains(term)).ToList<Client>());
				clientsList.AddRange(context.Users.OfType<Student>().Where(p => p.Name.Contains(term) || p.NIF.Contains(term)).ToList<Client>());
				return clientsList;
			}
			clientsList.AddRange(context.Users.OfType<Professor>().ToList<Client>());
			clientsList.AddRange(context.Users.OfType<Student>().ToList<Client>());
			return clientsList;
		}

		public List<Reservation> GetFutureReservations(string clientNif)
		{
			return context.Reservations.Where(r => r.Menu.Date >= DateTime.Now && (
				(r.Client != null && r.Client.NIF.Contains(clientNif) && r.Served == true)
			)).ToList();
		}

		internal object GetPastReservations(string clientNif)
		{
			return context.Reservations.Where(r => r.Menu.Date < DateTime.Now && (
				(r.Client != null && r.Client.NIF.Contains(clientNif) && r.Served == true)
			)).ToList();
		}

		public bool MarkAsServed (Reservation reservation)
		{
			try
			{
				ListReservations listReservations = new ListReservations();
				Invoice invoice = new Invoice();
				invoice.Date = DateTime.Now;
				InvoiceLine invoiceLine = new InvoiceLine();
				invoiceLine.Price = reservation.GetTotal();
				invoiceLine.Description = reservation.ToString();
				invoice.InvoiceLines.Add(invoiceLine);
				foreach (Extra extra in reservation.Extras)
				{
					InvoiceLine extraLine = new InvoiceLine();
					extraLine.Price = extra.Price;
					extraLine.Description = extra.Description;
					invoice.InvoiceLines.Add(extraLine);
				}
				context.Invoices.Add(invoice);
				reservation.Menu.QuantityAvailable--;
				reservation.Served = true;
				context.SaveChanges();
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}
	}
}
