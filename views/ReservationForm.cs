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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
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
    }
}
