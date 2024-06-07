using iCantina.controllers;
using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iCantina.views
{
	public partial class CanteenMenuDetails : Form
	{
		private CanteenMenuDetailsController controller;
		private models.Menu menu = null;

		public CanteenMenuDetails()
		{
			InitializeComponent();
			controller = new CanteenMenuDetailsController();
		}

		public CanteenMenuDetails(models.Menu menu) : this()
		{
			this.menu = menu;
		}

		private void CanteenMenu_Load(object sender, EventArgs e)
		{
			dishLister();
			monthCalendar.MinDate = DateTime.Now;
			if (this.menu != null)
			{
				monthCalendar.MinDate = menu.Date;
				monthCalendar.SelectionStart = menu.Date;
				if (menu.Date.Hour == 12)
				{
					rdoBtnLunch.Checked = true;
				}
				else
				{
					rdoBtnDinner.Checked = true;
				}
				numQuantity.Text = menu.QuantityAvailable.ToString();
				txtBoxPriceStudent.Text = menu.PriceStudent.ToString();
				txtBoxPriceProfessor.Text = menu.PriceProfessor.ToString();
				cmbBoxDish.SelectedItem = (Dish)menu.Dish;
				foreach (var item in menu.Extras)
				{
					chListBoxExtras.SetItemChecked(chListBoxExtras.Items.IndexOf(item), true);
				}
				checkIfCanActions();
			}
		}

		private void dishLister()
		{
			cmbBoxDish.DataSource = null;
			cmbBoxDish.DataSource = controller.GetDishesByType(helpers.DishTypeEnum.Meat);
			chListBoxExtras.DataSource = null;
			chListBoxExtras.DataSource = controller.GetExtras();
		}

		private void checkIfCanActions()
		{
			if (this.menu != null)
			{
				if (
				  cmbBoxDish.SelectedIndex != -1 &&
				  chListBoxExtras.CheckedItems.Count > 1 &&
				  numQuantity.Value > 0 &&
				  Regex.IsMatch(txtBoxPriceStudent.Text, @"^\d+(\.\d{1,2})?$") &&
				  Regex.IsMatch(txtBoxPriceProfessor.Text, @"^\d+(\.\d{1,2})?$"))
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
				if (
				  (cmbBoxDish.SelectedIndex != -1) &&
				  chListBoxExtras.CheckedItems.Count > 1 &&
				  numQuantity.Text != "" &&
				  Regex.IsMatch(txtBoxPriceStudent.Text, @"^\d+(\.\d{1,2})?$") &&
				  Regex.IsMatch(txtBoxPriceProfessor.Text, @"^\d+(\.\d{1,2})?$"))
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

		private void txtBoxPriceStudent_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtBoxPriceStudent.Text, @"^\d+(\.\d{1,2})?$"))
			{
				txtBoxPriceStudent.BackColor = System.Drawing.Color.White;
			}
			else
			{
				txtBoxPriceStudent.BackColor = System.Drawing.Color.Red;
			}
			checkIfCanActions();
		}

		private void txtBoxProfessor_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtBoxPriceProfessor.Text, @"^\d+(\.\d{1,2})?$"))
			{
				txtBoxPriceProfessor.BackColor = System.Drawing.Color.White;
			}
			else
			{
				txtBoxPriceProfessor.BackColor = System.Drawing.Color.Red;
			}
			checkIfCanActions();
		}

		private void cmbBoxDish_SelectedIndexChanged(object sender, EventArgs e)
		{
			checkIfCanActions();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				List<Extra> listExtras = new List<Extra>();
				foreach (var item in chListBoxExtras.CheckedItems)
				{
					listExtras.Add((Extra)item);
				}

				int dishId = -1;
				if (((models.Dish)cmbBoxDish.SelectedItem) != null)
					dishId = ((models.Dish)cmbBoxDish.SelectedItem).Id;

				TimeSpan ts;
				if (rdoBtnLunch.Checked)
				{
					ts = new TimeSpan(12, 00, 0);
				}
				else
				{
					ts = new TimeSpan(19, 00, 0);
				}

				bool success = controller.CreateMenu(
				  monthCalendar.SelectionStart + ts,
				  Convert.ToInt32(numQuantity.Text),
				  Convert.ToDouble(txtBoxPriceStudent.Text),
				  Convert.ToDouble(txtBoxPriceProfessor.Text),
				  listExtras,
				  dishId
				);

				if (success)
				{
					MessageBox.Show("Menu created successfully.");
				}
				else
				{
					MessageBox.Show("An error occurred while creating the menu.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				MessageBox.Show("An error occurred while creating the menu: " + ex.Message);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				List<Extra> listExtras = new List<Extra>();
				foreach (var item in chListBoxExtras.CheckedItems)
				{
					listExtras.Add((Extra)item);
				}

				TimeSpan ts;
				if (rdoBtnLunch.Checked)
				{
					ts = new TimeSpan(12, 00, 0);
				}
				else
				{
					ts = new TimeSpan(19, 00, 0);
				}

				controller.UpdateMenu(
				  menu.Id,
				  monthCalendar.SelectionStart + ts,
				  Convert.ToInt32(numQuantity.Text),
				  Convert.ToDouble(txtBoxPriceStudent.Text),
				  Convert.ToDouble(txtBoxPriceProfessor.Text),
				  listExtras,
				  ((models.Dish)cmbBoxDish.SelectedItem).Id
				);
				MessageBox.Show("Updated successfully.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while updating the menu: " + ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				controller.DeleteMenu(menu.Id);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while deleting the menu: " + ex.Message);
			}
		}

		private void chListBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
		{
			checkIfCanActions();
		}
	}
}
