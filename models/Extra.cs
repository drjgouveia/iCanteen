using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
	public class Extra
	{
		[Key]
		public int Id { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public bool Active { get; set; }
		public ICollection<Menu> Menus { get; set; }
		public ICollection<Reservation> Reservations { get; set; }


		public Extra()
		{
		}

		public Extra(string description, double price, bool isActive) : this()
		{
			Description = description;
			Price = price;
			Active = isActive;
		}

		public override string ToString()
		{
			return Description + " - " + Price + "€" + (Active ? "" : " (inactive)");
		}
	}
}
