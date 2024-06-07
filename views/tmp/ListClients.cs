using iCantina.controllers;
using System;
using System.Windows.Forms;

namespace iCantina.views
{
	public partial class ListClients : Form
	{
		private ListClientsController controller = null;
		private bool isStudent;

		public ListClients()
		{
			InitializeComponent();
			controller = new ListClientsController();
		}

		public ListClients(bool isStudent) : this()
		{
			InitializeComponent();
			this.isStudent = isStudent;
			//lstBoxClients.DataSource = null;
		}

		private void txtBoxSearch_TextChanged(object sender, EventArgs e)
		{
			lstBoxClients.DataSource = null;
			if (this.isStudent)
			{
				lstBoxClients.DataSource = controller.GetStudents(txtBoxSearch.Text);
			}
			else
			{
				lstBoxClients.DataSource = controller.GetProfessors(txtBoxSearch.Text);
			}
		}

		private void ListClients_Load(object sender, EventArgs e)
		{
			this.lstBoxClients.DataSource = null;
			if (this.isStudent)
			{
				this.lstBoxClients.DataSource = controller.GetStudents();
				this.Text = "List Students";
				lblClients.Text = "List of Students";
			}
			else
			{
				this.lstBoxClients.DataSource = controller.GetProfessors();
				this.Text = "List Professors";
				lblClients.Text = "List of Professors";
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			ClientDetails clientDetails = new ClientDetails(this.isStudent);
			clientDetails.Show();
			lstBoxClients.DataSource = null;
			if (this.isStudent)
			{
				lstBoxClients.DataSource = controller.GetStudents(txtBoxSearch.Text);
			}
			else
			{
				lstBoxClients.DataSource = controller.GetProfessors(txtBoxSearch.Text);
			}
		}
	}
}
