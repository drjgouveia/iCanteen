using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
	public class Reservation
	{
		[Key]
		public int Id { get; set; }
		public Student Student { get; set; }
		public Professor Professor { get; set; }
		public DateTime Date { get; set; }
		public Dish Dish { get; set; }
		public ICollection<Extra> Extras { get; set; }
		public Menu Menu { get; set; }
		public Penalty Penalty { get; set; }

		public Reservation()
		{
			Extras = new List<Extra>();
		}

		public override string ToString()
		{
			return $"Reservation: {(this.Student != null ? this.Student as Client : this.Professor as Client)} - {Date} - {Dish} - {Menu} - {Penalty}";
		}
	}
}
