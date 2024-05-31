using System;
using System.Windows.Forms;

namespace iCantina.views
{
	public partial class ListClients : Form
	{
		private controllers.ListClientsController controller = null;
		private bool isStudent;

		public ListClients()
		{
			InitializeComponent();
			controller = new controllers.ListClientsController();
		}

		public ListClients(bool isStudent) : this()
		{
			InitializeComponent();
			this.isStudent = isStudent;
		}

		private void txtBoxSearch_TextChanged(object sender, EventArgs e)
		{
			lstBoxClients.DataSource = null;
			if (isStudent)
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
			lstBoxClients.DataSource = null;
			if (isStudent)
			{
				this.Text = "List Students";
				lblClients.Text = "List of Students";
				lstBoxClients.DataSource = controller.GetStudents();
			}
			else
			{
				this.Text = "List Professors";
				lblClients.Text = "List of Professors";
				lstBoxClients.DataSource = controller.GetProfessors();
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			ClientDetails clientDetails = new ClientDetails(this.isStudent);
			clientDetails.Show();

		}
	}
}
