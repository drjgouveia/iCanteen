using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iCantina.controllers
{
  public class ListClientsController : Controller
  {
    public ListClientsController() : base()
    {
      Console.WriteLine("Client list controller initialized.");
    }

    public List<Student> GetStudents(string search = "")
    {
      if (search == "")
      {
        return context.Users.OfType<Student>().ToList();
      }
      else
      {
        return context.Users.OfType<Student>().Where(s => s.Name.Contains(search) || s.NIF.Contains(search)).ToList();
      }
    }

    public List<Professor> GetProfessors(string search = "")
    {
      if (search == "")
      {
        return context.Users.OfType<Professor>().ToList();
      }
      else
      {
        return context.Users.OfType<Professor>().Where(s => s.Name.Contains(search) || s.NIF.Contains(search) || s.Email.Contains(search)).ToList();
      }
    }
  }
}
