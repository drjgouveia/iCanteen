using iCantina.models;
using iCantina.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.controllers
{
    public class ListDishesController : Controller
    {
        public ListDishesController() : base() {
            Console.WriteLine("Dish list controller initialized.");
        }

        public List<Dish> GetDishes(string search = "") {
            if(search == "")
            {
                return context.Dishes.ToList();
            } else
            {
                return context.Dishes.Where(s => s.Description.Contains(search)).ToList();
            }

        }
    }
}
