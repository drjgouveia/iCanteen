using iCanteen.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCanteen.views.details
{
    public partial class PenaltyDetails : Form
    {
		private Penalty Penalty = null;
		private PenaltyDetailsController controller;

        public PenaltyDetails()
        {
            InitializeComponent();
			controller = new PenaltyDetailsController();
        }

        public PenaltyDetails(Penalty penalty) : this()
        {
			this.Penalty = penalty;
        }

		private void txtHours_TextChanged(object sender, EventArgs e)
		{
            if (txtHours.Text.Length > 0 && Regex.IsMatch(txtAmount.Text, "^[0-9]*$"))
            {
				txtHours.BackColor = Color.White;
			}
			else
			{
				txtHours.BackColor = Color.Red;
			}
		}

		private void txtAmount_TextChanged(object sender, EventArgs e)
		{
			if (txtAmount.Text.Length > 0 && Regex.IsMatch(txtAmount.Text, @"^\d+(\.\d{1,2})?$"))
			{
				txtAmount.BackColor = Color.White;
			}
			else
			{
				txtAmount.BackColor = Color.Red;
			}
		}

		public void CanPerformActions()
		{
			if (Regex.IsMatch(txtAmount.Text, @"^\d+(\.\d{1,2})?$") && txtAmount.Text.Length > 0 && txtHours.Text.Length > 0 && Regex.IsMatch(txtHours.Text, "^[0-9]*$"))
			{
				if (this.Penalty == null)
					btnCreate.Enabled = true;
				else
				{
					btnDelete.Enabled = true;
					btnEdit.Enabled = true;
				}
			}
			else
			{
				btnCreate.Enabled = false;
				btnEdit.Enabled = false;
				btnDelete.Enabled = false;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (txtHours.Text.Length == 0 || txtAmount.Text.Length == 0)
			{
				MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int hours = int.Parse(txtHours.Text);
				float amount = float.Parse(txtAmount.Text);
				controller.CreatePenalty(amount, hours);
				MessageBox.Show($"The penalty has been created", "Penalty", MessageBoxButtons.OK);
			}
		}
	}
}
