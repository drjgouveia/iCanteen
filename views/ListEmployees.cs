using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCanteen.views
{
    public partial class ListEmployees : Form
    {
        private controllers.ListEmployeesController controller = null;
        public ListEmployees()
        {
            InitializeComponent();
            controller = new controllers.ListEmployeesController();
        }

        private void txtBoxSearchEmployees_TextChanged(object sender, EventArgs e)
        {
            lstBoxEmployees.DataSource = null;
            lstBoxEmployees.DataSource = controller.GetEmployees(txtBoxSearchEmployees.Text);
        }

        private void ListEmployees_Load(object sender, EventArgs e)
        {
            lstBoxEmployees.DataSource = controller.GetEmployees();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            EmployeesDetails employees = new EmployeesDetails();
            employees.ShowDialog();
        }
    }
}
