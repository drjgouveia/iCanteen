using iCantina.controllers;
using iCantina.models;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iCantina.views
{
	public partial class ExtraDetails : Form
	{
		private ExtraDetailsController extrasController = null;
		private Extra extra = null;

		public ExtraDetails()
		{
			InitializeComponent();
			extrasController = new ExtraDetailsController();
		}

		public ExtraDetails(Extra extra) : this()
		{
			this.extra = extra;
			textBoxDescriptionExtras.Text = extra.Description;
			textBoxPriceExtras.Text = extra.Price.ToString();
			checkBoxActiveExtras.Checked = extra.Active;
		}

		private void checkIfCanActions()
		{
			if (Regex.IsMatch(textBoxDescriptionExtras.Text, @"^[a-zA-Z0-9\s]+$") && double.TryParse(textBoxPriceExtras.Text, out _))
			{
				if (this.extra != null)
				{
					btnCreate.Enabled = false;
					btnEdit.Enabled = true;
					btnDelete.Enabled = true;
				}
				else
				{
					btnCreate.Enabled = true;
					btnEdit.Enabled = false;
					btnDelete.Enabled = false;
				}
			}
			else
			{
				btnCreate.Enabled = false;
				btnEdit.Enabled = false;
				btnDelete.Enabled = false;
			}
		}

		private void textBoxPriceExtras_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(textBoxPriceExtras.Text, @"^\d+.{0,1}\d{0,2}$") && double.TryParse(textBoxPriceExtras.Text, out _))
			{
				textBoxPriceExtras.BackColor = System.Drawing.Color.White;
			}
			else
			{
				textBoxPriceExtras.BackColor = System.Drawing.Color.Red;
			}
			checkIfCanActions();
		}

		private void ExtraDetails_Load(object sender, EventArgs e)
		{

			checkIfCanActions();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			bool success = extrasController.CreateExtra(textBoxDescriptionExtras.Text, float.Parse(textBoxPriceExtras.Text), checkBoxActiveExtras.Checked);
			if (success)
			{
				MessageBox.Show("Extra created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Error creating extra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBoxDescriptionExtras_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(textBoxDescriptionExtras.Text, @"^[a-zA-Z0-9\s]+$"))
			{
				textBoxDescriptionExtras.BackColor = System.Drawing.Color.White;
			}
			else
			{
				textBoxDescriptionExtras.BackColor = System.Drawing.Color.Red;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			bool success = extrasController.EditExtra(extra.Id, textBoxDescriptionExtras.Text, float.Parse(textBoxPriceExtras.Text), checkBoxActiveExtras.Checked);
			if (success)
			{
				MessageBox.Show("Extra edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Error editing extra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool success = extrasController.DeleteExtra(extra.Id);
			if (success)
			{
				MessageBox.Show("Extra deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Error deleting extra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
