using iCanteen.controllers;
using iCantina.models;
using iCanteen.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCanteen.views.details;
using iCanteen.controllers.lists;

namespace iCanteen.views.lists
{
    public partial class ListPenalties : Form
    {
        private ListPenaltiesController controller;
       
        public ListPenalties()
        {
            InitializeComponent();
            controller = new ListPenaltiesController();
        }

        private void LoadData()
        {
            listBoxFines.DataSource = null;
            listBoxFines.DataSource = controller.GetPenalties(txtBoxSearchFines.Text);
        }

        private void ListFines_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtBoxSearchFines_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCreateFines_Click(object sender, EventArgs e)
        {
            PenaltyDetails penaltyDetails = new PenaltyDetails();
            penaltyDetails.ShowDialog();
            ListPenalties listPenalties = new ListPenalties();
            listPenalties.Show();
            this.Close();
        }

		private void listBoxFines_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			PenaltyDetails penaltyDetails = new PenaltyDetails((Penalty)listBoxFines.SelectedItem);
			penaltyDetails.ShowDialog();
			ListPenalties listPenalties = new ListPenalties();
			listPenalties.Show();
			this.Close();
		}
	}

 
}
