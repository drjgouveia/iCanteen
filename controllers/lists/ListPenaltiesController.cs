using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCanteen.controllers.lists
{
    public class ListPenaltiesController : Controller
    {
        public ListPenaltiesController() : base()
        {
            Console.WriteLine("List Penalties controller initialized.");
        }

        public List<Penalty> GetPenalties(string search = "")
        {

            if(search == "")
            {
                return context.Penalties.ToList();
            } else
            {
                return context.Penalties.Where(s => s.Amount.ToString().Contains(search)).ToList();
            }
      
        }
    }
 
}
