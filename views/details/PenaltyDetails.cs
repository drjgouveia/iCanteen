using iCanteen.controllers;
using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCanteen.views.details
{
    public partial class PenaltyDetails : Form
    {
        private PenaltyDetailsController controller;
        private Penalty penalty;
    
        public PenaltyDetails()
        {
            InitializeComponent();
            controller = new PenaltyDetailsController();
        }

        public PenaltyDetails(Penalty penalty) : this() 
        {
            txtAmount.Text = penalty.Amount.ToString();
        }


        private void PenaltyDetails_Load(object sender, EventArgs e)
        {
            if(penalty !=null)
            {
                txtAmount.Text = $"Penalty: {penalty.Amount:C}";
            }
                
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            bool sucess = controller.CreatePenalty(penalty.Id, penalty.Amount, penalty.Hours);
            if (sucess)
            {
                MessageBox.Show("Penalty created successfully.");
            }
            else
            {
                MessageBox.Show("Error creating penalty.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (penalty != null)
            {
                bool sucess = controller.DeletePenalty(penalty.Id);
                if (sucess)
                {
                    MessageBox.Show("Penalty deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Error deleting penalty.");
                }
            } else
            {
                MessageBox.Show("No penalty selected to delete.");
            }
            
        }
    }
}
