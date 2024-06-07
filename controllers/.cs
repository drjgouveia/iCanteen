using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Meat).ToList();
      }
      else if (type == DishTypeEnum.Vegetarian)
      {
        return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Vegetarian).ToList();
      }
      else if (type == DishTypeEnum.Fish)
      {
        return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Fish).ToList();
      }
      else
      {
        return new List<Dish>();
      }
    }

    public void CreateMenu(DateTime date, int quantity, double priceStudent, double priceProfessor, List<Extra> extras, int meatId = -1, int fishId = -1, int vegetarianId = -1)
    {
      models.Menu menu = new models.Menu();
      menu.Date = date;
      Dish meatDish = meatId == -1 ? null : context.Dishes.Find(meatId);
      if (meatDish != null)
        menu.Dishes.Add(meatDish);
      Dish fishDish = fishId == -1 ? null : context.Dishes.Find(fishId);
      if (fishDish != null)
        menu.Dishes.Add(fishDish);
      Dish vegetarianDish = vegetarianId == -1 ? null : context.Dishes.Find(vegetarianId);
      if (vegetarianDish != null)
        menu.Dishes.Add(vegetarianDish);

      foreach (var item in extras)
      {
        menu.Extras.Add((models.Extra)item);
      }
      menu.QuantityAvailable = quantity;
      menu.PriceStudent = priceStudent;
      menu.PriceProfessor = priceProfessor;
      context.Menus.Add(menu);
      context.SaveChanges();
    }

    public void UpdateMenu(int id, DateTime date, int quantity, double priceStudent, double priceProfessor, List<Extra> extras, int meatId = -1, int fishId = -1, int vegetarianId = -1)
    {
      if (context.Menus.FirstOrDefault(m => m.Date == date) != null)
        throw new Exception("Menu for that time already exists.");
      models.Menu menu = context.Menus.Find(id);
      menu.Date = date;
      Dish meatDish = meatId == -1 ? null : context.Dishes.Find(meatId);
      if (meatDish != null)
        menu.Dishes.Add(meatDish);
      Dish fishDish = fishId == -1 ? null : context.Dishes.Find(fishId);
      if (fishDish != null)
        menu.Dishes.Add(fishDish);
      Dish vegetarianDish = vegetarianId == -1 ? null : context.Dishes.Find(vegetarianId);
      if (vegetarianDish != null)
        menu.Dishes.Add(vegetarianDish);

      foreach (var item in extras)
      {
        menu.Extras.Add((models.Extra)item);
      }
      menu.QuantityAvailable = quantity;
      menu.PriceStudent = priceStudent;
      menu.PriceProfessor = priceProfessor;
      context.SaveChanges();
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
  }
}
