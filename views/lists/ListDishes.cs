using iCanteen.views.details;
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

namespace iCanteen.views.lists
{
	public partial class ListDishes : Form
	{
		private ListDishesController controller;

		public ListDishes()
		{
			InitializeComponent();
			controller = new ListDishesController();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			DishDetails dishDetails = new DishDetails();
			dishDetails.ShowDialog();
			ListDishes listDishes = new ListDishes();
			listDishes.Show();
			this.Close();
		}

		private void ListDishes_Load(object sender, EventArgs e)
		{
			listBoxDishes.DataSource = null;
			listBoxDishes.DataSource = controller.GetDishes(txtBoxSearch.Text);
		}

		private void txtBoxSearch_TextChanged(object sender, EventArgs e)
		{
			listBoxDishes.DataSource = null;
			listBoxDishes.DataSource = controller.GetDishes(txtBoxSearch.Text);
		}

		private void listBoxClients_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			DishDetails dishDetails = new DishDetails((Dish)listBoxDishes.SelectedItem);
			dishDetails.ShowDialog();
			ListDishes listDishes = new ListDishes();
			listDishes.Show();
			this.Close();
		}
	}
}
