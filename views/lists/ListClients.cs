using iCantina.controllers;
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
			this.isStudent = isStudent;
		}
		   
		private void LoadClients()
		{
			this.listBoxClients.DataSource = null;
			if (this.isStudent)
			{
				listBoxClients.DataSource = controller.GetStudents(txtBoxSearch.Text);
			}
			else
			{
				listBoxClients.DataSource = controller.GetProfessors(txtBoxSearch.Text);
			}
		}

		private void ListClients_Load(object sender, EventArgs e)
		{
			if (this.isStudent)
			{
				this.Text = "List Students";
				lblClients.Text = "List of Students";
			}
			else
			{
				this.Text = "List Professors";
				lblClients.Text = "List of Professors";
			}
			listBoxClients.SelectedItem = null;
			LoadClients();
		}

		private void txtBoxSearch_TextChanged(object sender, EventArgs e)
		{
			LoadClients();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{

			ClientDetails clientDetails = new ClientDetails(this.isStudent);
			clientDetails.ShowDialog();
			ListClients listClients = new ListClients(this.isStudent);
			listClients.Show();
			this.Close();
		}

		private void listBoxClients_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxClients.SelectedItem != null)
			{
				if (this.isStudent)
				{
					Student student = (Student)listBoxClients.SelectedItem;
					ClientDetails clientDetails = new ClientDetails(this.isStudent, student);
					clientDetails.ShowDialog();
				}
				else
				{
					Professor professor = (Professor)listBoxClients.SelectedItem;
					ClientDetails clientDetails = new ClientDetails(this.isStudent, professor);
					clientDetails.ShowDialog();
				}
				ListClients listClients = new ListClients(this.isStudent);
				listClients.Show();
				this.Close();
			}
		}
	}
}
