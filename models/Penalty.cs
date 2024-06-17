using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
	public class Penalty
	{
		[Key]
		public int Id { get; set; }
		public float Amount { get; set; }
		public int Hours { get; set; }


		public Penalty()
		{
		}

		public override string ToString()
		{
			return $"Penalty: {Amount}� for {Hours} hours";
		}
	}
}
