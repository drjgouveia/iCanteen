﻿using iCanteen.controllers;
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
				controller.MarkAsServed(reservation.Id);
				MessageBox.Show("Reservation marked as served");
				ListReservations listReservations = new ListReservations();
				listReservations.Show();
				this.Close();
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
