using iCantina.controllers;
using iCantina.models;
using System;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class Login : Form
  {
    private LoginController controller;
    public Login()
    {
      InitializeComponent();
      controller = new LoginController();
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
      string username = txtBoxUsername.Text;
      Employee employee = controller.Authenticate(username);
      if (employee != null)
      {
        MessageBox.Show("Login successful!");
        MainPage mainPage = new MainPage(employee);
        this.Hide();
        mainPage.Show();
      }
      else
      {
        MessageBox.Show("Invalid username.");
      }
    }
  }
}
