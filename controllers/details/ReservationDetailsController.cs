using iCantina.controllers;
using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iCanteen.controllers
{
	public class ReservationDetailsController : Controller
	{
		public ReservationDetailsController() : base()
		{
		}

		public List<Client> GetClients(string term="")
		{
			List<Client> clientsList = context.Professors.ToList<Client>();
			clientsList.AddRange(context.Students.ToList<Client>());
			return clientsList;
		}

		public List<Extra> GetExtras()
		{
			return context.Extras.Where(e => e.Active).ToList();
		}

		public bool CreateReservation(DateTime date, string clientNif, ICollection<int> extras, int menuId, bool isLunch, DishTypeEnum dishType)
		{
			Reservation reservation = new Reservation();
			Menu menu = context.Menus.Find(menuId);
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
			Student student = context.Students.FirstOrDefault(s => s.NIF.Contains(clientNif));
			reservation.Student = student;
			Professor professor = null;
			if (student == null)
            {
				professor = context.Professors.FirstOrDefault(s => s.NIF.Contains(clientNif));
				reservation.Professor = professor;
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
	}
}
