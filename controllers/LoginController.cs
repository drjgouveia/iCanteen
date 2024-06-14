using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.controllers
{
  public class LoginController : Controller
  {
    public LoginController() : base()
    {
      Console.WriteLine("Login controller initialized.");
    }

    public Employee Authenticate(string username)
    {
      try
      {
        Employee employee = context.Users.OfType<Employee>().FirstOrDefault(e => e.Username == username);

        return employee;
      }
      catch (Exception e)
      {
      }
      return null;
    }
  }
}
