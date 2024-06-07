using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iCantina.controllers
{
	public class ListExtrasController : Controller
	{
		public ListExtrasController() : base()
		{
			Console.WriteLine("Extras list controller initialized.");
		}

		public List<Extra> GetExtras(string search = "")
		{
			if (search == "")
			{
				return context.Extras.ToList();
			}
			else
			{
				return context.Extras.Where(s => s.Description.Contains(search)).ToList();
			}
		}
	}
}
