using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iCantina.controllers
{
	public class DishDetailsController : Controller
	{
		public DishDetailsController() : base()
		{
			Console.WriteLine("Dish Details controller initialized.");
		}

		public bool CreateDish(string description, DishTypeEnum type, bool isActive)
		{
			try
			{
				Dish dish = new Dish();
				dish.Description = description;
				dish.Type = type;
				dish.Active = isActive;
				Console.WriteLine("Creating dish...");
				context.Dishes.Add(dish);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool UpdateDish(int id, string description, DishTypeEnum type, bool isActive)
		{
			try
			{
				Dish dish = context.Dishes.Find(id);
				dish.Description = description;
				dish.Type = type;
				dish.Active = isActive;
				Console.WriteLine("Updating dish...");
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteDish(int id)
		{
			try
			{
				Dish dish = context.Dishes.Find(id);
				context.Dishes.Remove(dish);
				Console.WriteLine("Deleting dish...");
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
