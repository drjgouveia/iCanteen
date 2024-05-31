using iCantina.controllers;
using System;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class ExtrasForms : Form
  {
    public ExtrasForms()
    {
      InitializeComponent();
    }

    private void buttonExtras_Click(object sender, EventArgs e)
    {
      string description = textBoxDescriptionExtras.Text;
      double price = Convert.ToDouble(textBoxPriceExtras.Text);
      bool isActive = checkBoxActiveExtras.Checked;

      ExtrasController extrasController = new ExtrasController();
      extrasController.ExtrasVerification(description, price, isActive);
    }
  }
}
