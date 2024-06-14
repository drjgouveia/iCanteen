using iCantina.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace iCantina.controllers
{
	public class ListCanteenMenuController : Controller
	{
		public ListCanteenMenuController() : base()
		{
		}

		public List<string> GetWeeksOfYear(int year)
		{
			List<string> weeks = new List<string>();
			DateTime startDate = new DateTime(year, 1, 1);
			DateTime endDate = new DateTime(year, 12, 31);

			Calendar calendar = CultureInfo.InvariantCulture.Calendar;
			int week = 1;

			for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
			{
				if (calendar.GetDayOfWeek(date) == DayOfWeek.Monday)
				{
					weeks.Add($"Week {week}");
					week++;
				}
			}

			return weeks;
		}

		public List<models.Menu> GetMenus(int week, int year)
		{
			Calendar calendar = CultureInfo.InvariantCulture.Calendar;
			CalendarWeekRule calendarWeekRule = CultureInfo.InvariantCulture.DateTimeFormat.CalendarWeekRule;
			IEnumerable<models.Menu> menus = context.Menus.Include("Extras").Include("Dish").Where(m => 
				m.Date.Year == year
			).ToList();
			menus = from m in menus
					where calendar.GetWeekOfYear(m.Date, calendarWeekRule, DayOfWeek.Monday) == week
					select m;
			return menus.ToList();
		}

		internal object GetYears()
		{
			if (context.Menus.Count() == 0)
				return new List<int> { DateTime.Now.Year };
			return context.Menus.Select(m => m.Date.Year).Distinct().ToList();
		}

	}
}
