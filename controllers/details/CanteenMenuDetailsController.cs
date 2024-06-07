using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace iCantina.controllers
{
	public class CanteenMenuDetailsController : Controller
	{
		public CanteenMenuDetailsController() : base()
		{
			Console.WriteLine("Canteen Menu controller initialized.");
		}

		public List<Dish> GetDishesByType(DishTypeEnum type)
		{
			if (type == DishTypeEnum.Meat)
			{
				return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Meat && dish.Active == true).ToList();
			}
			else if (type == DishTypeEnum.Vegetarian)
			{
				return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Vegetarian && dish.Active == true).ToList();
			}
			else if (type == DishTypeEnum.Fish)
			{
				return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Fish && dish.Active == true).ToList();
			}
			else
			{
				return new List<Dish>();
			}
		}

		public bool CreateMenu(DateTime date, int quantity, double priceStudent, double priceProfessor, List<Extra> extras, int dishId = -1)
		{
			try
			{
				if (context.Menus.FirstOrDefault(m => m.Date == date) != null)
					throw new Exception("Menu for that time already exists.");
				models.Menu menu = new models.Menu();
				menu.Date = date;
				Dish dish = dishId == -1 ? null : context.Dishes.Find(dishId);
				if (dish != null)
					menu.Dish = dish;

				menu.Extras.Clear();
				List<Extra> listExtras = new List<Extra>();
				foreach (var item in extras)
				{
					menu.Extras.Add((models.Extra)item);
				}
				menu.QuantityAvailable = quantity;
				menu.PriceStudent = priceStudent;
				menu.PriceProfessor = priceProfessor;
				context.Menus.Add(menu);
				context.SaveChanges();
				return true;
			} catch (Exception e)
			{
				return false;
			}
		}

		public void UpdateMenu(int id, DateTime date, int quantity, double priceStudent, double priceProfessor, List<Extra> extras, int dishId = -1)
		{
			models.Menu menu = context.Menus.Find(id);
			menu.Date = date;

			Dish dish = dishId == -1 ? null : context.Dishes.Find(dishId);
			if (dish != null)
				menu.Dish = dish;

			menu.Extras.Clear();
			List<Extra> listExtras = new List<Extra>();
			foreach (var item in extras)
			{
				listExtras.Add((models.Extra)item);
			}
			menu.Extras = listExtras;
			menu.QuantityAvailable = quantity;
			menu.PriceStudent = priceStudent;
			menu.PriceProfessor = priceProfessor;
			base.context.Menus.AddOrUpdate(menu);
			base.context.SaveChanges();
		}

		public void DeleteMenu(int id)
		{
			models.Menu menu = context.Menus.Find(id);
			context.Menus.Remove(menu);
			context.SaveChanges();
		}

		public List<Extra> GetExtras()
		{
			return context.Extras.Where(extra => extra.Active).ToList();
		}

		public List<Dish> GetDishes()
		{
			return context.Dishes.Where(dish => dish.Active).ToList();
		}
	}
}
