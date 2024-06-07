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
				clientsList = context.Professors.Where(prof => prof.Name.Contains(term) || prof.NIF.Contains(term)).ToList<Client>();
				clientsList.AddRange(context.Students.Where(stud => stud.Name.Contains(term) || stud.NIF.Contains(term)).ToList<Client>());
				return clientsList;
			}
			clientsList = context.Professors.ToList<Client>();
			clientsList.AddRange(context.Students.ToList<Client>());
			return clientsList;
		}

		public List<Reservation> GetFutureReservations(string clientNif)
		{
			return context.Reservations.Where(r => r.Date >= DateTime.Now && (
				(r.Professor != null && r.Professor.NIF.Contains(clientNif))
					||
				(r.Student != null && r.Student.NIF.Contains(clientNif))
			)).ToList();
		}

		internal object GetPastReservations(string clientNif)
		{
			return context.Reservations.Where(r => r.Date < DateTime.Now && (
				(r.Professor != null && r.Professor.NIF.Contains(clientNif))
					||
				(r.Student != null && r.Student.NIF.Contains(clientNif))
			)).ToList();
		}
	}
}
