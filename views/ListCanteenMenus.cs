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
  public partial class ListCanteenMenus : Form
  {
    private controllers.ListCanteenMenuController controller = null;

    public ListCanteenMenus()
    {
      InitializeComponent();
      controller = new controllers.ListCanteenMenuController();
    }



    private void txtBoxSearch_TextChanged(object sender, EventArgs e)
    {
      lstBoxMenus.DataSource = null;
      lstBoxMenus.DataSource = controller.GetMenus(txtBoxSearch.Text);
    }

    private void ListCanteenMenus_Load(object sender, EventArgs e)
    {
      lstBoxMenus.DataSource = controller.GetMenus();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      CanteenMenuDetails canteenMenu = new CanteenMenuDetails();
      canteenMenu.ShowDialog();
    }
  }
}
