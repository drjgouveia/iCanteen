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
			if (menu == null)
				monthCalendar.MinDate = DateTime.Now;

			if (this.menu != null)
			{
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
				
				if (menu.Dish != null) {
					foreach (var item in cmbBoxDish.Items)
					{
						if (((models.Dish)item).Id == (menu.Dish).Id)
						{
							cmbBoxDish.SelectedItem = item;
						}
					}
				}
				if (menu.Extras != null)
				{
					var items = controller.GetExtras();
					foreach (var item in items)
					{
						foreach (var extra in menu.Extras)
						{
							if (extra.Id == ((Extra)item).Id)
							{
								chListBoxExtras.SetItemChecked(chListBoxExtras.Items.IndexOf(item), true);
							}
						}
					}
				}
				checkIfCanActions();
			}
		}

		private void dishLister()
		{
			cmbBoxDish.DataSource = null;
			cmbBoxDish.DataSource = controller.GetDishes();
			chListBoxExtras.DataSource = null;
			chListBoxExtras.DataSource = controller.GetExtras();
		}

		private void checkIfCanActions()
		{
			if (this.menu != null)
			{
				if (
				  cmbBoxDish.SelectedIndex != -1 &&
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

				DateTime date = monthCalendar.SelectionStart;
				if (rdoBtnLunch.Checked)
				{
					date = DateTime.ParseExact(date.ToString("dd/MM/yyyy") + " 12:00:00", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
				}
				else
				{
					date = DateTime.ParseExact(date.ToString("dd/MM/yyyy") + " 19:00:00", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
				}

				bool success = controller.CreateMenu(
				  date,
				  Convert.ToInt32(numQuantity.Text),
				  float.Parse(txtBoxPriceStudent.Text),
				  float.Parse(txtBoxPriceProfessor.Text),
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
				this.Close();
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

				DateTime date = monthCalendar.SelectionStart;
				if (rdoBtnLunch.Checked)
				{
					date = DateTime.ParseExact(date.ToString("dd/MM/yyyy") + " 12:00:00", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
				}
				else
				{
					date = DateTime.ParseExact(date.ToString("dd/MM/yyyy") + " 19:00:00", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
				}

				controller.UpdateMenu(
				  menu.Id,
				  date,
				  Convert.ToInt32(numQuantity.Text),
				  float.Parse(txtBoxPriceStudent.Text),
				  float.Parse(txtBoxPriceProfessor.Text),
				  listExtras,
				  ((models.Dish)cmbBoxDish.SelectedItem).Id
				);
				MessageBox.Show("Updated successfully.");
				this.Close();
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
				this.Close();
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
