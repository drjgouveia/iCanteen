using iCanteen.views;
using iCanteen.views.details;
using iCanteen.views.lists;
using iCantina.models;
using System;
using System.Windows.Forms;

namespace iCantina.views
{
	public partial class MainPage : Form
	{
		private Employee employee;

		public MainPage(Employee employee)
		{
			InitializeComponent();
			this.employee = employee;
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			this.Text = $"Main page (logged in as {this.employee.Name})";
			lblUser.Text = $"Welcome, {this.employee.Name}!";
		}

		private void btnDishes_Click(object sender, EventArgs e)
		{
			ListDishes listDishes = new ListDishes();
			listDishes.Show();
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			ListCanteenMenus listCanteenMenus = new ListCanteenMenus();
			listCanteenMenus.Show();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Close();
		}

		private void btnStudents_Click(object sender, EventArgs e)
		{
			ListClients listStudents = new ListClients(true);
			listStudents.Show();
		}

		private void btnProfessors_Click(object sender, EventArgs e)
		{
			ListClients listProfessors = new ListClients(false);
			listProfessors.Show();
		}

		private void btnReservations_Click(object sender, EventArgs e)
		{
			ListReservations listReservations = new ListReservations();
			listReservations.Show();
		}

		private void btnEmployees_Click(object sender, EventArgs e)
        {
			ListEmployees listEmployees = new ListEmployees();
			listEmployees.Show();
        }

		private void btnExtras_Click(object sender, EventArgs e)
		{
			ListExtras listExtras = new ListExtras();
			listExtras.Show();
		}

        private void btnFines_Click(object sender, EventArgs e)
        {
			ListPenalties listPenalties = new ListPenalties();
			listPenalties.Show(); 
        }
    }
}
