using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
	public class Reservation
	{
		[Key]
		public int Id { get; set; }
		public Client Client { get; set; }
		public DateTime Date { get; set; }
		public Dish Dish { get; set; }
		public ICollection<Extra> Extras { get; set; }
		public Menu Menu { get; set; }
		public Penalty Penalty { get; set; }
		public bool Served { get; set; }

		public Reservation()
		{
			Extras = new List<Extra>();
		}

		public float GetTotal()
		{
			float total = 0;
			foreach (Extra extra in Extras)
			{
				total += extra.Price;
			}
			if (this.Client is Student)
				total += this.Menu.PriceStudent;
			else
				total += this.Menu.PriceProfessor;

			if (Penalty != null)
				total += Penalty.Amount;

			return total;
		}

		public override string ToString()
		{
			return $"Reservation: {(this.Client)} - {Date} - {Menu} - {Penalty}";
		}
	}
}
