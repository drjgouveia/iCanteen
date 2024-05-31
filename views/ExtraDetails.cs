using iCantina.controllers;
using System;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class ExtraDetails : Form
  {
    public ExtraDetails()
    {
      InitializeComponent();
    }

    private void buttonExtras_Click(object sender, EventArgs e)
    {
      string description = textBoxDescriptionExtras.Text;
      double price = Convert.ToDouble(textBoxPriceExtras.Text);
      bool isActive = checkBoxActiveExtras.Checked;

      ExtraDetailsController extrasController = new ExtraDetailsController();
      extrasController.ExtrasVerification(description, price, isActive);
    }
  }
}
