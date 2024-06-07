using iCantina.helpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
	public class Dish
	{
		[Key]
		public int Id { get; set; }
		public DishTypeEnum Type { get; set; }
		public string Description { get; set; }
		public bool Active { get; set; }
		public ICollection<Menu> Menus { get; set; }
		public ICollection<Reservation> Reservations { get; set; }

		public Dish()
		{
		}

		public Dish(DishTypeEnum dishType, bool active)
		{
			Active = active;
			Type = dishType;
		}

		public override string ToString()
		{
			return Type + " - " + Description;
		}

	}


}
