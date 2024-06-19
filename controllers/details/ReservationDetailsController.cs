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

		public bool CreateReservation(Reservation reservation)
		{
			iCantina.models.Menu menu = reservation.Menu;
			if (menu == null)
				throw new Exception("Menu not available");

			if (menu.QuantityAvailable == 0)
				throw new Exception("Menu not available");

			menu.QuantityAvailable--;

            reservation.Dish = menu.Dish;

			reservation.Client.Balance -= reservation.GetTotal();
			reservation.Client.Balance -= CalculatePenaltyHours(reservation.Menu.Date) != null ? CalculatePenaltyHours(reservation.Menu.Date).Amount : 0.0f;

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

		public Penalty CalculatePenaltyHours(DateTime date)
		{

			List<Penalty> penalties = new List<Penalty>();
			penalties = context.Penalties.OrderByDescending(x => x.Hours).ToList();

            foreach (var rate in penalties)
            {
				if ((date - DateTime.Now).Hours == rate.Hours)
                {
                    return rate;
                }
            }
			return null;
        }


        public bool GenerateInvoice(Invoice invoice, Client client)
		{
			try
			{
				client.Invoices.Add(invoice);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
    }
}
