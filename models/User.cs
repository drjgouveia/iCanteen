using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
  public class User
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string NIF { get; set; }

    public User()
    {
    }

    public User(string name, string nif)
    {
      Name = name;
      NIF = nif;
    }

    public override string ToString()
    {
      return $"Name: {Name}, NIF: {NIF}";
    }
  }
}
