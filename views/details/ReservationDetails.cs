
using iCanteen.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace iCantina.views
{
	public partial class ReservationDetails : Form
	{
		private ReservationDetailsController controller = null;
		private bool isStudent = false;
        private const int LunchHourLimit = 10;
        private const int DinnerHourLimit = 16;
        private const float PenaltyHour = (float)2.50;


        public ReservationDetails()
		{
			InitializeComponent();
			controller = new ReservationDetailsController();
		}

		private void ListCanteenMenus_Load(object sender, EventArgs e)
		{
			Calendar calendar = CultureInfo.InvariantCulture.Calendar;
			CalendarWeekRule calendarWeekRule = CultureInfo.InvariantCulture.DateTimeFormat.CalendarWeekRule;
			int week = calendar.GetWeekOfYear(DateTime.Now, calendarWeekRule, DayOfWeek.Monday);

			cmbBoxClients.DataSource = controller.GetClients();
			cmbBoxYear.DataSource = null;
			cmbBoxYear.DataSource = controller.GetYears();
			cmbBoxYear.SelectedItem = DateTime.Now.Year;
			cmbBoxWeek.DataSource = null;
			cmbBoxWeek.DataSource = controller.GetWeeksOfYear(DateTime.Now.Year);
			cmbBoxWeek.SelectedItem = $"Week {week}";

			List<models.Menu> menus = controller.GetMenus(week, DateTime.Now.Year);
            lstBoxMenus.DataSource = null;
			lstBoxMenus.DataSource = menus;
			getPrice();
		}
			               
        private void btnCreate_Click(object sender, EventArgs e)
		{
			getPrice();
			CanteenMenuDetails canteenMenu = new CanteenMenuDetails();
			canteenMenu.ShowDialog();
			ReservationDetails listCanteenMenus = new ReservationDetails();
			listCanteenMenus.Show();
			this.Close();
		
        }

        private void lstBoxMenus_DoubleClick(object sender, EventArgs e)
		{
			CanteenMenuDetails canteenMenu = new CanteenMenuDetails((models.Menu)lstBoxMenus.SelectedItem);
			canteenMenu.ShowDialog();
			ReservationDetails listCanteenMenus = new ReservationDetails();
			listCanteenMenus.Show();
			this.Close();
		}

		private void cmbBoxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbBoxWeek.DataSource = null;
			cmbBoxWeek.DataSource = controller.GetWeeksOfYear((int)cmbBoxYear.SelectedItem);
			cmbBoxWeek.SelectedItem = "Week 1";
			lstBoxMenus.DataSource = null;
			lstBoxMenus.DataSource = controller.GetMenus(1, (int)cmbBoxYear.SelectedItem);
			chckBoxExtras.DataSource = null;
			getPrice();
		}

		private void cmbBoxWeek_SelectedIndexChanged(object sender, EventArgs e)
		{
			chckBoxExtras.DataSource = null;
			lstBoxMenus.DataSource = null;
			try { 
				lstBoxMenus.DataSource = controller.GetMenus(cmbBoxWeek.SelectedIndex + 1, (int)cmbBoxYear.SelectedItem);
			} catch (Exception ex)
			{
				MessageBox.Show("There is no menu created. Create one and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close(); 
				return;
			}
			getPrice();
		}

		private void lstBoxMenus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstBoxMenus.SelectedItem != null)
			{
				chckBoxExtras.DataSource = null;
				chckBoxExtras.DataSource = ((models.Menu)lstBoxMenus.SelectedItem).Extras;
				chckBoxExtras.Refresh();
				getPrice();
			}
			else
			{
				btnDelete.Enabled = false;
			}
		}

		private void btnAddClient_Click(object sender, EventArgs e)
		{
			bool isStudent = MessageBox.Show("Is the client a student?", "Student", MessageBoxButtons.YesNo) == DialogResult.Yes;
			ClientDetails clientDetails = new ClientDetails(isStudent);
			clientDetails.ShowDialog();
			ReservationDetails reservationDetails = new ReservationDetails();
			reservationDetails.Show();
			this.Close();
		}

		private void getPrice()
		{
			if (lstBoxMenus.SelectedItem != null)
			{
				models.Menu menu = (models.Menu)lstBoxMenus.SelectedItem;
				double price = 0;
				isStudent = controller.IsClientStudent((Client)cmbBoxClients.SelectedItem);
				if (isStudent)
				{
					price = menu.PriceStudent;
				}
				else
				{
					price = menu.PriceProfessor;
				}
				foreach (Extra extra in chckBoxExtras.CheckedItems)
				{
					price += extra.Price;
				}
				lblCost.Text = $"Cost: {price}";
			}
		}

		private void cmbBoxClients_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbBoxClients.SelectedItem != null)
			{
				lblBalance.Text = $"Balance: {((Client)cmbBoxClients.SelectedItem).Balance}";
			}
			getPrice();
		}

		private void chckBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
		{
			getPrice();
		}

		private void chckBoxExtras_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			// If the item being checked is not already checked, increment the count
			if (chckBoxExtras.CheckedItems.Count == 3)
			{
				MessageBox.Show("You can only check up to 3 items.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				e.NewValue = CheckState.Unchecked; // Cancel the check
			}
			getPrice();
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			if (lstBoxMenus.SelectedItem == null)
			{
				MessageBox.Show("Please select a menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (cmbBoxClients.SelectedItem == null)
			{
				MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			models.Menu menu = (models.Menu)lstBoxMenus.SelectedItem;
			Reservation reservation = new Reservation();
			foreach (Extra extra in chckBoxExtras.CheckedItems)
			{
				reservation.Extras.Add(extra);
			}
			reservation.Date = DateTime.Now;
			reservation.Dish = menu.Dish;
			reservation.Menu = menu;
			reservation.Client = (Client)cmbBoxClients.SelectedItem;
            /*
			foreach (Penalty penalty in controller.GetPenalties())
			{
				if (penalty.Hours < DateTime.Now.Hour - menu.Date.Hour)
				{
					reservation.Penalty = penalty;
				}
			}
			*/

            Client client = (Client)cmbBoxClients.SelectedItem;
			if (client.Balance < reservation.GetTotal())
			{
				MessageBox.Show("The client does not have enough balance to make the reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (DateTime.Now < reservation.Menu.Date)
			{
				if (controller.CreateReservation(reservation))
				{
					MessageBox.Show("Reservation created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("An error occurred while creating the reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} 
			else
			{
				MessageBox.Show("You can only reserve menus for today and next days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}
	}
}
