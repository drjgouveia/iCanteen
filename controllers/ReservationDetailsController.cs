using iCantina.controllers;
using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCanteen.controllers
{
	public class ReservationDetailsController : Controller
	{
		public ReservationDetailsController() : base()
		{
		}

		public List<Client> GetClients()
		{
			List<Client> clientsList = context.Professors.ToList<Client>();
			clientsList.AddRange(context.Students.ToList<Client>());
			return clientsList;
		}

		public bool CreateReservation(DateTime date, int quantity, float price, int clientId, ICollection<int> extras, int menuId, bool isLunch, DishTypeEnum dishType)
		{
			Reservation reservation = new Reservation();

			return true;
		}
	}
}
