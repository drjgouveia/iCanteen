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
        public ReservationDetails()
        {
            InitializeComponent();
        }

        private void checkedListBoxExtrasReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ICollection<Extra> extras = new List<Extra>();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            
        }

        private void reloadClients()
        { }

		private void btnAddClient_Click(object sender, EventArgs e)
		{
            ClientDetails clientDetails = new ClientDetails(MessageBox.Show("Do you want to create a student?", "If you select yes, you'll be prompted to enter data for a student, if you select no you'll be prompted to enter data for a professor", MessageBoxButtons.YesNo) == DialogResult.Yes);
            clientDetails.ShowDialog();

		}
	}
}
