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
            if (string.IsNullOrEmpty(txtBoxUserNameEmployee.Text)) {

                MessageBox.Show("Missing username");
                return;

            } else if (string.IsNullOrEmpty(txtBoxNameEmployee.Text)) {
                MessageBox.Show("Missing name");
                return;
            }
            else if (string.IsNullOrEmpty(txtBoxNifEmployee.Text)) {
                MessageBox.Show("Missing nif");
                return;

            } else
            {
                controller.CreateEmployee(txtBoxUserNameEmployee.Text, txtBoxNameEmployee.Text, txtBoxNifEmployee.Text);
            }

        }

        private void CheckIfCanActions()
        {
            if (this.employee != null) {
                btnEditEmployee.Enabled = false;
                btnDeleteEmployee.Enabled = false;
                if (Regex.IsMatch(txtBoxUserNameEmployee.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(txtBoxNameEmployee.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(txtBoxNifEmployee.Text, @"^\d{9}$"))
                {
                    btnCreateEmployee.Enabled = true;
                }
                else
                {
                    btnCreateEmployee.Enabled = false;
                }
            } else {
                btnCreateEmployee.Enabled = false;
                if (Regex.IsMatch(txtBoxUserNameEmployee.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(txtBoxNameEmployee.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(txtBoxNifEmployee.Text, @"^\d{9}$"))
                {
                    btnEditEmployee.Enabled = true;
                    btnDeleteEmployee.Enabled = true;
                }
                else
                {
                    btnEditEmployee.Enabled = false;
                    btnDeleteEmployee.Enabled = false;
                }
            }
        }
       
      
        private void txtBoxUserNameEmployee_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtBoxUserNameEmployee.Text, @"^[a-zA-Z ]+$"))
            {
                txtBoxUserNameEmployee.BackColor = Color.White;
                if (this.employee != null)
                    btnEditEmployee.Enabled = true;
                else
                    CheckIfCanActions();
            }
            else
            {
                txtBoxUserNameEmployee.BackColor = Color.Red;
                btnCreateEmployee.Enabled = false;
                btnEditEmployee.Enabled = false;
            }
        }

        private void txtBoxNameEmployee_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtBoxNameEmployee.Text, @"^[a-zA-Z ]+$"))
            {
                txtBoxNameEmployee.BackColor = Color.White;
                if(this.employee != null)
                    btnEditEmployee.Enabled = true;
                else 
                    CheckIfCanActions();
            } else
            {
                txtBoxNameEmployee.BackColor= Color.Red;
                btnCreateEmployee.Enabled = false;
                btnEditEmployee.Enabled = false;
            }
        }

        private void txtBoxNifEmployee_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtBoxNameEmployee.Text, @"^[a-zA-Z ]+$"))
            {
                txtBoxNifEmployee.BackColor = Color.White; 
                if(this.employee != null) 
                    btnEditEmployee.Enabled = true; 
                else
                    CheckIfCanActions();
            } else
            {
                txtBoxNifEmployee .BackColor = Color.Red;
                btnCreateEmployee .Enabled = false;
                btnEditEmployee .Enabled = false;
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            controller.UpdateEmployee(this.employee.Id, txtBoxUserNameEmployee.Text, txtBoxNameEmployee.Text, txtBoxNifEmployee.Text );

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            controller.DeleteEmployee(this.employee.Id);
        }
    }



}
