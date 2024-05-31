using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iCantina.controllers
{
  public class ClientDetailsController : Controller
  {
    public ClientDetailsController() : base()
    {
      Console.WriteLine("Client Details controller initialized.");
    }

    public bool CreateStudent(string name, string nif, int number, float balance = 0)
    {
      try
      {
        Student student = new Student();
        student.Name = name;
        student.NIF = nif;
        student.StudentNumber = number;
        student.Balance = balance;
        Console.WriteLine("Creating student...");
        context.Students.Add(student);
        context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool CreateProfessor(string name, string nif, string email, float balance = 0)
    {
      try
      {
        Professor professor = new Professor();
        professor.Name = name;
        professor.Email = email;
        professor.NIF = nif;
        professor.Balance = balance;
        Console.WriteLine("Creating professor...");
        context.Professors.Add(professor);
        context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool UpdateStudent(int id, string name, string nif, int number, float balance = 0)
    {
      try
      {
        Student student = context.Students.Find(id);
        student.Name = name;
        student.NIF = nif;
        student.StudentNumber = number;
        student.Balance = balance;
        Console.WriteLine("Updating student...");
        context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool UpdateProfessor(int id, string name, string nif, string email, float balance = 0)
    {
      try
      {
        Professor professor = context.Professors.Find(id);
        professor.Name = name;
        professor.Email = email;
        professor.NIF = nif;
        professor.Balance = balance;
        Console.WriteLine("Updating professor...");
        context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool DeleteStudent(int id)
    {
      try
      {
        Student student = context.Students.Find(id);
        Console.WriteLine("Deleting student...");
        context.Students.Remove(student);
        context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool DeleteProfessor(int id)
    {
      try
      {
        Professor professor = context.Professors.Find(id);
        Console.WriteLine("Deleting professor...");
        context.Professors.Remove(professor);
        context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public List<Student> GetStudents()
    {
      return context.Students.ToList();
    }

    public List<Professor> GetProfessors()
    {
      return context.Professors.ToList();
    }
  }
}
