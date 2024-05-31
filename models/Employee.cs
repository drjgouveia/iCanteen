namespace iCantina.models
{
  public class Employee : User
  {
    public string Username { get; set; }

    public Employee()
    {
    }

    public Employee(string name, string nif, string username) : base(name, nif)
    {
      Username = username;
    }

    public override string ToString()
    {
      return Name + " - " + NIF + " - " + Username;
    }
  }
}
