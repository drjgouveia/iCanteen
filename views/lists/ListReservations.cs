using iCanteen.controllers;
using iCantina.models;
using iCantina.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace iCanteen.views
{
	public partial class ListReservations : Form
	{
		private ListReservationsController controller;

		public ListReservations()
		{
			InitializeComponent();
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
			controller = new ListReservationsController();
            Load_Reservations();

        }
        private void Load_Reservations()
        {
            comboBoxClients.DataSource = controller.GetClients();
            if (comboBoxClients.SelectedItem != null)
            {
                listBoxReservations.DataSource = null;
				listBoxReservations.DataSource = controller.GetFutureReservations(((Client)comboBoxClients.SelectedItem).NIF);
                listBoxPastReservations.DataSource = null;
                listBoxPastReservations.DataSource = controller.GetServedReservations(((Client)comboBoxClients.SelectedItem).NIF);
            }
        }

        private void ListReservations_Load(object sender, EventArgs e)
		{
			Load_Reservations();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			ReservationDetails reservationDetails = new ReservationDetails();
			reservationDetails.ShowDialog();
			ListReservations listReservations = new ListReservations();
			listReservations.Show();
			this.Close();
		}

		private void btnMark_Click(object sender, EventArgs e)
		{
			if (listBoxReservations.SelectedItem != null)
			{
				Reservation reservation = (Reservation)listBoxReservations.SelectedItem;
				controller.MarkAsServed(reservation);
				MessageBox.Show("Reservation marked as served");
			}

			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
				if(saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					PdfDocument pdf = new PdfDocument();
					
					pdf.Info.Title = "Invoice of Reservation";
					PdfPage pdfPage = pdf.AddPage();

					InvoiceLine line = new InvoiceLine();
					foreach (Reservation reservation in listBoxReservations.Items)
					{
						line.Description = reservation.ToString();
						line.Price = reservation.GetTotal();
					}
					
                    
					XGraphics gfx = XGraphics.FromPdfPage(pdfPage);

					XFont font = new XFont("Verdana", 20);

					gfx.DrawString("Invoice of Reservation", font, XBrushes.Black, 
						new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);

					pdf.Save(saveFileDialog.FileName);
				}
			}

		}

		private void listBoxReservations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxReservations.SelectedItem != null)
			{

			}

		}
	}	
}
