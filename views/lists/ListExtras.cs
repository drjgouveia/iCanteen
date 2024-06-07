using iCantina.controllers;
using iCantina.models;
using iCantina.views;
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
	public partial class ListExtras : Form
	{
		private ListExtrasController controller;

		public ListExtras()
		{
			InitializeComponent();
			controller = new ListExtrasController();
		}

		private void LoadData()
		{
			listBoxExtras.DataSource = null;
			listBoxExtras.DataSource = controller.GetExtras(txtBoxSearch.Text);
		}

		private void ListExtras_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void txtBoxSearch_TextChanged(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			ExtraDetails extraDetails = new ExtraDetails();
			extraDetails.ShowDialog();
			ListExtras listExtras = new ListExtras();
			listExtras.Show();
			this.Close();
		}

		private void listBoxExtras_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxExtras.SelectedItem != null)
			{
				ExtraDetails extraDetails = new ExtraDetails((Extra)listBoxExtras.SelectedItem);
				extraDetails.ShowDialog();
				ListExtras listExtras = new ListExtras();
				listExtras.Show();
				this.Close();
			}
		}
	}
}
