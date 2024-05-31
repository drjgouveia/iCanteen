namespace iCantina.models
{
  public class Student : Client
  {
    public int StudentNumber { get; set; }

    public Student() { }

    public Student(string name, string nif, float balance, int studentNumber) : base(name, nif, balance)
    {
      StudentNumber = studentNumber;
    }

    public override string ToString()
    {
      return Name + " - " + NIF + " - " + StudentNumber;
    }
  }
}
