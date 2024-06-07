using iCantina.controllers;
using iCantina.helpers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iCanteen.views.details
{
	public partial class DishDetails : Form
	{
		private DishDetailsController controller;
		private Dish dish = null;

		public DishDetails()
		{
			InitializeComponent();
			controller = new DishDetailsController();
		}

		public DishDetails(Dish dish) : this()
		{
			txtDescription.Text = dish.Description;
			cbBoxType.SelectedItem = dish.Type;
			chBoxActive.Checked = dish.Active;
			checkIfCanActions();
		}

		private void DishDetails_Load(object sender, EventArgs e)
		{
			cbBoxType.DataSource = Enum.GetValues(typeof(DishTypeEnum));
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			bool success = controller.CreateDish(txtDescription.Text, (DishTypeEnum)cbBoxType.SelectedItem, chBoxActive.Checked);
			if (success)
			{
				MessageBox.Show("Dish created successfully.");
			}
			else
			{
				MessageBox.Show("Error creating dish.");
			}
			this.Close();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			bool success = controller.UpdateDish(dish.Id, txtDescription.Text, (DishTypeEnum)cbBoxType.SelectedItem, chBoxActive.Checked);
			if (success)
			{
				MessageBox.Show("Dish updated successfully.");
			}
			else
			{
				MessageBox.Show("Error updating dish.");
			}
			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool success = controller.DeleteDish(dish.Id);
			if (success)
			{
				MessageBox.Show("Dish deleted successfully.");
			}
			else
			{
				MessageBox.Show("Error deleting dish.");
			}
			this.Close();
		}

		private void checkIfCanActions()
		{
			if (dish != null)
			{
				if (txtDescription.Text.Length > 0 && Regex.IsMatch(txtDescription.Text, @"^[a-zA-Z0-9\s]+$"))
				{
					btnCreate.Enabled = false;
					btnEdit.Enabled = true;
					btnDelete.Enabled = true;
				}
				else
				{
					btnCreate.Enabled = false;
					btnEdit.Enabled = false;
					btnDelete.Enabled = false;
				}
			}
			else
			{
				if (txtDescription.Text.Length > 0 && Regex.IsMatch(txtDescription.Text, @"^[a-zA-Z0-9\s]+$"))
				{
					btnCreate.Enabled = true;
					btnEdit.Enabled = false;
					btnDelete.Enabled = false;
				}
				else
				{
					btnCreate.Enabled = false;
					btnEdit.Enabled = false;
					btnDelete.Enabled = false;
				}
			}
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{
			if (txtDescription.Text.Length > 0 && Regex.IsMatch(txtDescription.Text, @"^[a-zA-Z0-9\s]+$"))
			{
				txtDescription.BackColor = Color.White;
			}
			else
			{
				txtDescription.BackColor = Color.Red;
			}
			checkIfCanActions();
		}
	}
}
