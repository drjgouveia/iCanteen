using System.Collections.Generic;
using System.Linq;

namespace iCantina.controllers
{
	public class ListCanteenMenuController : Controller
	{
		public ListCanteenMenuController() : base()
		{
		}

		public List<models.Menu> GetMenus(string search = "")
		{
			if (search != "")
				return context.Menus.Where(m => m.Date.ToString("dd/mm/YYYY HH:mm").Contains(search)).ToList();
			return context.Menus.ToList();
		}
	}
}
