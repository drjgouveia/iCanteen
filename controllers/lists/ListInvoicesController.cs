using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCanteen.controllers.lists
{
    public class ListInvoicesController : Controller
    {
        public ListInvoicesController() : base()
        {
            Console.WriteLine("Invoices list controller initialized.");
        }

        public List<Invoice> GetInvoices(string search = "")
        {
            if (search == "")
            {
                return context.Invoices.ToList();
            }
            else
            {
                return context.Invoices.Where(s => s.ToString().Contains(search)).ToList();
            }
        }
    }
}
