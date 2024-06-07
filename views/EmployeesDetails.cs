using iCanteen.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCanteen.views
{
    public partial class EmployeesDetails : Form
    {
        private EmployeesDetailsController controller;
        private Employee employee = null;
        private string title;
        private string isEmployee; 
 
        public EmployeesDetails()
        {
            InitializeComponent();
            
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            bool sucess = false;
      
            if (string.IsNullOrEmpty(txtBoxUserNameEmployee.Text)) {

                MessageBox.Show("Missing username"); 
                return;

            } else if (string.IsNullOrEmpty(txtBoxNameEmployee.Text)) {
                MessageBox.Show("Missing name");
                return;
            }
              else if (string.IsNullOrEmpty(txtBoxNif.Text)) {
                MessageBox.Show("Missing nif");
                return;

            } else
            {
                controller.CreateEmployee(txtBoxUserNameEmployee.Text, txtBoxNameEmployee.Text, txtBoxNif.Text);
            }
                 
        }

        private void txtBoxUserNameEmployee_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtBoxNameEmployee.Text, @"^[a-zA-Z ]+$"))
            {
                txtBoxNameEmployee.BackColor = Color.White;
                if (this.profe != null || this.student != null)
                    btnEdit.Enabled = true;
                else
                    CheckIfCanActions();
            }
            else
            {
                txtBoxName.BackColor = Color.Red;
                btnCreate.Enabled = false;
                btnEdit.Enabled = false;
            }
        }
    }



}
