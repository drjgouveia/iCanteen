using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCanteen.controllers
{
    public class EmployeesDetailsController : Controller
    {
        public EmployeesDetailsController() : base() 
        {
            Console.WriteLine("Employee Details controller initialized.");
        }

        public bool CreateEmployee(string username, string name, string nif)
        {
            try
            {
                Employee employee = new Employee();
                employee.Username = username;
                employee.Name = name;
                employee.NIF = nif;
                Console.WriteLine("Creating employee...");
                context.Users.Add(employee);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateEmployee(int id, string username, string name, string nif)
        {
            try
            {
                Employee employee = context.Users.OfType<Employee>().FirstOrDefault(e => e.Id == id);
                employee.Name = name;
                employee.NIF = nif;
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
                Employee employee = context.Users.OfType<Employee>().FirstOrDefault(e => e.Id == id);
                Console.WriteLine("Deleting employee...");
				context.Users.Remove(employee);
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
            return context.Users.OfType<Employee>().ToList();
        }
    }
}
