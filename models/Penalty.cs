using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
  public class Penalty
  {
    [Key]
    public int Id { get; set; }
    public double Amount { get; set; }
    public int Hours { get; set; }

    public Penalty()
    {
    }
  }
}
