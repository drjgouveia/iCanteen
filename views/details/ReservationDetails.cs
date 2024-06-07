using iCanteen.controllers;
using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class ReservationDetails : Form
    {
        private ReservationDetailsController controller;

		public ReservationDetails()
        {
            InitializeComponent();
            controller = new ReservationDetailsController();
		}

        private void checkedListBoxExtrasReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ICollection<Extra> extras = new List<Extra>();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            
        }

        private void reloadClients()
        {
            comboBoxClientCreate.DataSource = null;
            comboBoxClientCreate.DataSource = controller.GetClients();
        }

		private void btnAddClient_Click(object sender, EventArgs e)
		{
            ClientDetails clientDetails = new ClientDetails(MessageBox.Show("If you select yes, you'll be prompted to enter data for a student, if you select no you'll be prompted to enter data for a professor", "Student or Professor?", MessageBoxButtons.YesNo) == DialogResult.Yes);
            clientDetails.ShowDialog();
            reloadClients();
		}

		private void checkedListBoxExtrasReservation_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (checkedListBoxExtrasReservation.CheckedItems.Count > 3)
			{
				if (!checkedListBoxExtrasReservation.GetItemChecked(checkedListBoxExtrasReservation.SelectedIndex))
					e.NewValue = e.CurrentValue;
			}
		}

		private void ReservationDetails_Load(object sender, EventArgs e)
		{
            reloadClients();
            reloadExtras();
		}

		private void reloadExtras()
		{
			checkedListBoxExtrasReservation.DataSource = null;
			checkedListBoxExtrasReservation.DataSource = controller.GetExtras();
		}
	}
}
