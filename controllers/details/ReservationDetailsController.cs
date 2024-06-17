using iCantina.controllers;
using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace iCanteen.controllers
{
	public class ReservationDetailsController : Controller
	{
        public ReservationDetailsController() : base()
		{
		}

		public List<Client> GetClients(string term="")
		{
			List<Client> clientsList = new List<Client>();
			if (term != "")
			{
				clientsList.AddRange(context.Users.OfType<Professor>().Where(p => p.Name.Contains(term) || p.NIF.Contains(term)).ToList<Client>());
				clientsList.AddRange(context.Users.OfType<Student>().Where(p => p.Name.Contains(term) || p.NIF.Contains(term)).ToList<Client>());
				return clientsList;
			}
			clientsList.AddRange(context.Users.OfType<Professor>().ToList<Client>());
			clientsList.AddRange(context.Users.OfType<Student>().ToList<Client>());
			return clientsList;
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

		public List<iCantina.models.Menu> GetMenus(int week, int year)
		{
			Calendar calendar = CultureInfo.InvariantCulture.Calendar;
			CalendarWeekRule calendarWeekRule = CultureInfo.InvariantCulture.DateTimeFormat.CalendarWeekRule;
			IEnumerable<iCantina.models.Menu> menus = context.Menus.Include("Extras").Include("Dish").Where(m =>
				m.Date.Year == year
			).ToList();
			menus = from m in menus
					where calendar.GetWeekOfYear(m.Date, calendarWeekRule, DayOfWeek.Monday) == week
					select m;
			return menus.ToList();
		}

		internal object GetYears()
		{
			return context.Menus.Select(m => m.Date.Year).Distinct().ToList();
		}

		public List<Extra> GetExtras()
		{
			return context.Extras.Where(e => e.Active).ToList();
		}

		public bool CreateReservation(DateTime date, string clientNif, ICollection<int> extras, int menuId, bool isLunch, DishTypeEnum dishType)
		{
			Reservation reservation = new Reservation();
			iCantina.models.Menu menu = context.Menus.Find(menuId);
			if (menu == null)
				throw new Exception("Menu not available");

			if (menu.QuantityAvailable == 0)
				throw new Exception("Menu not available");

			menu.QuantityAvailable--;
			if (isLunch)
				date = DateTime.ParseExact(date.ToString("dd/MM/yyyy") + " 12:00:00", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
			else
				date = DateTime.ParseExact(date.ToString("dd/MM/yyyy") + " 19:00:00", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

			reservation.Date = date;
			reservation.Menu = menu;
			Student student = context.Users.OfType<Student>().FirstOrDefault(s => s.NIF.Contains(clientNif));
			reservation.Client = student;
			Professor professor = null;
			if (student == null)
            {
				professor = context.Users.OfType<Professor>().FirstOrDefault(s => s.NIF.Contains(clientNif));
				reservation.Client = professor;
			}

			if (student == null && professor == null)
				throw new Exception("Client not found");

			List<Extra> extrasList = new List<Extra>();
			foreach (int extraId in extras)
			{
				Extra extra = context.Extras.Find(extraId);
				extrasList.Add(extra);
			}
			reservation.Extras = extrasList;
			reservation.Dish = menu.Dish;
			context.Reservations.Add(reservation);
			context.SaveChanges();
			return true;

        }

		public bool IsClientStudent(Client client)
		{
			return context.Users.OfType<Student>().Any(s => s.NIF == client.NIF);
		}

		public List<Penalty> GetPenalties()
		{
			return context.Penalties.ToList();
		}

		public bool CreateReservation(Reservation reservation)
		{
			try
			{
				context.Reservations.Add(reservation);
				reservation.Client.Balance -= reservation.GetTotal();
				context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

        public static float CalculatePenaltyHours(DateTime date)
        {
            const int LunchHourLimit = 10;
            const int DinnerHourLimit = 16;
            const float PenaltyHour = 2.50f;
			float penalyAmount = 0;
			

            TimeSpan timeSpan = DateTime.Now - date;
            double totalHours = timeSpan.TotalHours;

            if (totalHours > LunchHourLimit && totalHours <= DinnerHourLimit)
            {
                return (float)(totalHours - LunchHourLimit) * PenaltyHour;
            }
            else if (totalHours > DinnerHourLimit)
            {
                return (float)(totalHours - DinnerHourLimit) * PenaltyHour;
            }

            return penalyAmount;

        }

        public bool GenerateInvoice(Invoice invoice)
		{
			try
			{
				context.Invoices.Add(invoice);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
    }
}
