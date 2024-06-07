using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace iCanteen.controllers
{
    public class EmployeesDetailsController : Controller
    {
        public EmployeesDetailsController() : base() 
        {
            Console.WriteLine("Employee Details controller initialized.");
        }

        public bool CreateEmployee(string name, string nif, string username)
        {
            try
            {
                Employee employee = new Employee();
                employee.Name = name;
                employee.NIF = nif;
                employee.Username = username;
                Console.WriteLine("Creating employee...");
                context.Employees.Add(employee);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateEmployee(int id, string name, string nif, string username)
        {
            try
            {
                Employee employee = context.Employees.Find(id);
                employee.Name = name;
                employee.NIF = nif;
                employee.Username = username;
                Console.WriteLine("Updating employee...");
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                Employee employee = context.Employees.Find(id);
                Console.WriteLine("Deleting employee...");
                context.Employees.Remove(employee);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public List<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }
    }
}
