using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCanteen.controllers
{
    public class ListEmployeesController : Controller
    {
        public ListEmployeesController() : base() //vai buscar o construtor do controller 
        {
            Console.WriteLine("Employee list controller initialized");
        }

        public List<Employee> GetEmployees(string search = "")
        {
            if (search == "")
            {
                return context.Users.OfType<Employee>().ToList();  
            }   
            else
            {
                return context.Users.OfType<Employee>().Where(s=>s.Name.Contains(search) || s.NIF.Contains(search)).ToList();
            }
        }

    }
}
