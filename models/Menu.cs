using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
  public class Menu
  {
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Dish Dish { get; set; }
    public ICollection<Extra> Extras { get; set; }
    public int QuantityAvailable { get; set; }
    public float PriceStudent { get; set; }
    public float PriceProfessor { get; set; }

    public Menu()
    {
        Extras = new List<Extra>();
    }

    public override string ToString()
    {
      return $"{Dish.Description} - {Dish.Type} - {Date.ToString("dd/MM/yyyy HH:mm")}";
    }
  }
}
