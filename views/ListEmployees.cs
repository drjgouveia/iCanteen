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
        private Employee employee = null;
        public ListEmployees()
        {
            InitializeComponent();
            controller = new controllers.ListEmployeesController();
        }

        public void LoadEmployee()
        {
            lstBoxEmployees.DataSource = controller.GetEmployees(txtBoxSearchEmployees.Text);
        }

        private void ListEmployees_Load(object sender, EventArgs e)
        {
            lstBoxEmployees.SelectedItem = null;
            LoadEmployee();
        }

        private void txtBoxSearchEmployees_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            EmployeesDetails employeesDetails = new EmployeesDetails();
            employeesDetails.ShowDialog();
            ListEmployees listEmployees = new ListEmployees();
            listEmployees.Show();
            this.Close();
        }

        private void lstBoxEmployees_DoubleClick(object sender, EventArgs e)
        {
            if(lstBoxEmployees.SelectedItem != null)
            {

                EmployeesDetails employeesDetails = new EmployeesDetails((Employee)lstBoxEmployees.SelectedItem);
                employeesDetails.ShowDialog();
                ListEmployees listEmployees = new ListEmployees();
                listEmployees.Show();
                this.Close();
            }
        }
    }
}
