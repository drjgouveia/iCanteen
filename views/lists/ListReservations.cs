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

namespace iCanteen.views
{
	public partial class ListReservations : Form
	{
		private ListReservationsController controller;

		public ListReservations()
		{
			InitializeComponent();
			controller = new ListReservationsController();
		}

		private void ListReservations_Load(object sender, EventArgs e)
		{
			comboBoxClients.DataSource = controller.GetClients();
			if (comboBoxClients.SelectedItem != null){
				listBoxReservations.DataSource = controller.GetFutureReservations(((Client)comboBoxClients.SelectedItem).NIF);
				listBoxPastReservations.DataSource = controller.GetPastReservations(((Client)comboBoxClients.SelectedItem).NIF);
			}
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
			}
		}
	}
}
