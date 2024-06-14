using System;
using System.Collections.Generic;
using System.Globalization;
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

		private void ListCanteenMenus_Load(object sender, EventArgs e)
		{
			Calendar calendar = CultureInfo.InvariantCulture.Calendar;
			CalendarWeekRule calendarWeekRule = CultureInfo.InvariantCulture.DateTimeFormat.CalendarWeekRule;
			int week = calendar.GetWeekOfYear(DateTime.Now, calendarWeekRule, DayOfWeek.Monday);
			cmbBoxYear.DataSource = null;
			cmbBoxYear.DataSource = controller.GetYears();
			cmbBoxYear.SelectedItem = DateTime.Now.Year;
			cmbBoxWeek.DataSource = null;
			cmbBoxWeek.DataSource = controller.GetWeeksOfYear(DateTime.Now.Year);
			cmbBoxWeek.SelectedItem = $"Week {week}";

			List<models.Menu> menus = controller.GetMenus(week, DateTime.Now.Year);
			lstBoxMenus.DataSource = null;
			lstBoxMenus.DataSource = menus;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			CanteenMenuDetails canteenMenu = new CanteenMenuDetails();
			canteenMenu.ShowDialog();
			ListCanteenMenus listCanteenMenus = new ListCanteenMenus();
			listCanteenMenus.Show();
			this.Close();
		}

		private void lstBoxMenus_DoubleClick(object sender, EventArgs e)
		{
			CanteenMenuDetails canteenMenu = new CanteenMenuDetails((models.Menu)lstBoxMenus.SelectedItem);
			canteenMenu.ShowDialog();
			ListCanteenMenus listCanteenMenus = new ListCanteenMenus();
			listCanteenMenus.Show();
			this.Close();
		}

		private void cmbBoxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbBoxWeek.DataSource = null;
			cmbBoxWeek.DataSource = controller.GetWeeksOfYear((int)cmbBoxYear.SelectedItem);
			cmbBoxWeek.SelectedItem = "Week 1";
			lstBoxMenus.DataSource = null;
			lstBoxMenus.DataSource = controller.GetMenus(1, (int)cmbBoxYear.SelectedItem);
		}

		private void cmbBoxWeek_SelectedIndexChanged(object sender, EventArgs e)
		{
			lstBoxMenus.DataSource = null;
			lstBoxMenus.DataSource = controller.GetMenus(cmbBoxWeek.SelectedIndex + 1, cmbBoxYear.SelectedItem != null ? (int)cmbBoxYear.SelectedItem : (int)DateTime.Now.Year);
		}
	}
}
