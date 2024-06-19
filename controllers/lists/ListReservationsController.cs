using iCanteen.views;
using iCantina.controllers;
using iCantina.helpers;
using iCantina.models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

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
			return context.Reservations
				.Where(r => ((r.Client != null && r.Menu.Date > DateTime.Now && r.Client.NIF.Contains(clientNif) && r.Served == false)))
				.Include(r => r.Dish)
				.Include(r => r.Menu)
				.Include(r => r.Penalty)
				.ToList();
		}

		internal object GetServedReservations(string clientNif)
		{
			return context.Reservations.Where(r => ((r.Client != null && r.Client.NIF.Contains(clientNif) && r.Served == true)))
				.Include (r => r.Dish)
				.Include (r => r.Menu)
				.Include (r => r.Penalty)
				.ToList();
		}

		public bool MarkAsServed(int reservationId)
		{
			try
			{
				Reservation reservation = context.Reservations.Find(reservationId);
				Invoice invoice = new Invoice();
				invoice.Client = reservation.Client;
				invoice.Date = DateTime.Now;
				invoice.Total = reservation.GetTotal();
				invoice.Client = reservation.Client;
				invoice.InvoiceLines = new List<InvoiceLine>();
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
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        PdfDocument pdf = new PdfDocument();

                        pdf.Info.Title = "Invoice of Reservation";
                        PdfPage pdfPage = pdf.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
                        XFont font = new XFont("Verdana", 20);
                        XFont titleFont = new XFont("Verdana", 20);
                        XFont itemFont = new XFont("Verdana", 12);
                        XFont totalFont = new XFont("Verdana", 14);
                        gfx.DrawString("Invoice of Reservation", titleFont, XBrushes.Black,
                        new XRect(0, 20, pdfPage.Width.Point, 40), XStringFormats.TopCenter);

                        double total = 0;
                        int yOffset = 60;

                        
                        foreach (var item in invoice.InvoiceLines)
                        {
                            item.Description = item.Description;
                            item.Price = item.Price;


                            gfx.DrawString($"Description: {item.Description}", itemFont, XBrushes.Black,
                            new XRect(40, yOffset, pdfPage.Width.Point - 80, 20), XStringFormats.TopLeft);
                            yOffset += 20;

                            gfx.DrawString($"Price: {item.Price:C}", itemFont, XBrushes.Black,
                            new XRect(60, yOffset, pdfPage.Width.Point - 120, 20), XStringFormats.TopLeft);
                            yOffset += 20;

                        }

                        pdf.Save(saveFileDialog.FileName);
                    }
                }
                return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}
	}
}
