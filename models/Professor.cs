namespace iCantina.models
{
  public class Professor : Client
  {
    public string Email { get; set; }

    public Professor()
    {
    }

    public Professor(string name, string nif, float balance, string email) : base(name, nif, balance)
    {
      Email = email;
    }

    public override string ToString()
    {
      return NIF + " - " + Name + " - " + Email;
    }
  }
}
