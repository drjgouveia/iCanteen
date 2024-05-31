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
    /*
        public List<MeatDish> GetMeatDishes(string search = "") {
            if(search == "")
            {
                return context.MeatDishes.ToList();
            } else
            {
                return context.MeatDishes.Where(s => s.Name.Contains(search)).ToList();
            }

        }

        public List<FishDish> GetFishDishes (string search = "")
        {
            if(search == "")
            {
                return context.FishDishes.ToList();
            }
            else
            {
                return context.FishDishes.Where(s => s.Name.Contains(search)).ToList();
            }
        }

        public List<VegetarianDish> GetVegetarianDishes (string search = "")
        {
            if(search == "")
            {
                return context.VegetarianDishes.ToList();
            }
            else
            {
                return context.VegetarianDishes.Where(s => s.Name.Contains(search)).ToList();
            }
        }*/
    }
}
