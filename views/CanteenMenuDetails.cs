using iCantina.controllers;
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
      monthCalendar.MinDate = DateTime.Now;
      dishLister();

      if (this.menu != null)
      {
        monthCalendar.SelectionStart = menu.Date;
        numQuantity.Text = menu.QuantityAvailable.ToString();
        txtBoxPriceStudent.Text = menu.PriceStudent.ToString();
        txtBoxPriceProfessor.Text = menu.PriceProfessor.ToString();
        cmbBoxMeatDish.SelectedItem = menu.Dishes.FirstOrDefault(dish => dish.Type == helpers.DishTypeEnum.Meat);
        cmbBoxFishDish.SelectedItem = menu.Dishes.FirstOrDefault(dish => dish.Type == helpers.DishTypeEnum.Fish);
        cmbBoxVegetarianDish.SelectedItem = menu.Dishes.FirstOrDefault(dish => dish.Type == helpers.DishTypeEnum.Vegetarian);
        foreach (var item in menu.Extras)
        {
          chListBoxExtras.SetItemChecked(chListBoxExtras.Items.IndexOf(item), true);
        }
      }
      checkIfCanActions();
    }

    private void dishLister()
    {
      cmbBoxMeatDish.DataSource = null;
      cmbBoxMeatDish.DataSource = controller.GetDishesByType(helpers.DishTypeEnum.Meat);
      cmbBoxFishDish.DataSource = null;
      cmbBoxFishDish.DataSource = controller.GetDishesByType(helpers.DishTypeEnum.Fish);
      cmbBoxVegetarianDish.DataSource = null;
      cmbBoxVegetarianDish.DataSource = controller.GetDishesByType(helpers.DishTypeEnum.Vegetarian);
      chListBoxExtras.DataSource = null;
      chListBoxExtras.DataSource = controller.GetExtras();
    }

    private void checkIfCanActions()
    {
      if (this.menu != null) { 
        if (
          (cmbBoxMeatDish.SelectedIndex != -1 || chBoxMeatNotAvailable.Checked) &&
          (cmbBoxFishDish.SelectedIndex != -1 || chBoxFishNotAvailable.Checked) &&
          (cmbBoxVegetarianDish.SelectedIndex != -1 || chBoxVegetarianNotAvailable.Checked) &&
          chListBoxExtras.CheckedItems.Count > 1 &&
          numQuantity.Text != "" &&
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
          (cmbBoxMeatDish.SelectedIndex != -1 || chBoxMeatNotAvailable.Checked) &&
          (cmbBoxFishDish.SelectedIndex != -1 || chBoxFishNotAvailable.Checked) &&
          (cmbBoxVegetarianDish.SelectedIndex != -1 || chBoxVegetarianNotAvailable.Checked) &&
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

    private void cmbBoxMeatDish_SelectedIndexChanged(object sender, EventArgs e)
    {
      checkIfCanActions();
    }

    private void chBoxMeatNotAvailable_CheckedChanged(object sender, EventArgs e)
    {
      if (chBoxMeatNotAvailable.Checked)
      {
        cmbBoxMeatDish.Enabled = false;
      }
      else
      {
        cmbBoxMeatDish.Enabled = true;
      }
      checkIfCanActions();
    }

    private void chBoxFishNotAvailable_CheckedChanged(object sender, EventArgs e)
    {
      if (chBoxFishNotAvailable.Checked)
      {
        cmbBoxFishDish.Enabled = false;
      }
      else
      {
        cmbBoxFishDish.Enabled = true;
      }
      checkIfCanActions();
    }

    private void chBoxVegetarianNotAvailable_CheckedChanged(object sender, EventArgs e)
    {
      if (chBoxVegetarianNotAvailable.Checked)
      {
        cmbBoxVegetarianDish.Enabled = false;
      }
      else
      {
        cmbBoxVegetarianDish.Enabled = true;
      }
      checkIfCanActions();
    }

    private void cmbBoxVegetarianDish_SelectedIndexChanged(object sender, EventArgs e)
    {
      checkIfCanActions();
    }

    private void cmbBoxFishDish_SelectedIndexChanged(object sender, EventArgs e)
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

        int meatId = -1;
        if (((models.Dish)cmbBoxMeatDish.SelectedItem) != null)
          meatId = ((models.Dish)cmbBoxMeatDish.SelectedItem).Id;

        int fishId = -1;
        if (((models.Dish)cmbBoxFishDish.SelectedItem) != null)
          fishId = ((models.Dish)cmbBoxFishDish.SelectedItem).Id;

        int vegetarianId = -1;
        if (((models.Dish)cmbBoxVegetarianDish.SelectedItem) != null)
          vegetarianId = ((models.Dish)cmbBoxVegetarianDish.SelectedItem).Id;

        TimeSpan ts;
        if (rdoBtnLunch.Checked)
        {
          ts = new TimeSpan(12, 00, 0);
        }
        else
        {
          ts = new TimeSpan(19, 00, 0);
        }

        MessageBox.Show(((models.Dish)cmbBoxMeatDish.SelectedItem).ToString());
        controller.CreateMenu(
          monthCalendar.SelectionStart + ts,
          Convert.ToInt32(numQuantity.Text),
          Convert.ToDouble(txtBoxPriceStudent.Text),
          Convert.ToDouble(txtBoxPriceProfessor.Text),
          listExtras,
          meatId,
          fishId,
          vegetarianId
        );
      } catch (Exception ex)
      {
        MessageBox.Show(ex.StackTrace);
        MessageBox.Show("An error occurred while creating the menu: " + ex.Message);
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      try {
        List<Extra> listExtras = new List<Extra>();
        foreach (var item in chListBoxExtras.CheckedItems)
        {
          listExtras.Add((Extra)item);
        }

        controller.UpdateMenu(
          menu.Id,
          monthCalendar.SelectionStart,
          Convert.ToInt32(numQuantity.Text),
          Convert.ToDouble(txtBoxPriceStudent.Text),
          Convert.ToDouble(txtBoxPriceProfessor.Text),
          listExtras,
          ((models.Dish)cmbBoxMeatDish.SelectedItem).Id,
          ((models.Dish)cmbBoxFishDish.SelectedItem).Id,
          ((models.Dish)cmbBoxVegetarianDish.SelectedItem).Id
        );
      } catch (Exception ex)
      {
        MessageBox.Show("An error occurred while updating the menu: " + ex.Message);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      try
      {
        controller.DeleteMenu(menu.Id);
      } catch (Exception ex)
      {
        MessageBox.Show("An error occurred while deleting the menu: " + ex.Message);
      }
    }
  }
}
