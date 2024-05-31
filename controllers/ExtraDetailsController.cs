using iCantina.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.controllers
{
    public class ExtraDetailsController : Controller
    {
        public ExtraDetailsController() : base() { }

        public void ExtrasVerification(string description, double price, bool isActive) 
        {
           if(isActive==true && string.IsNullOrWhiteSpace(description.ToString()) && string.IsNullOrWhiteSpace(price.ToString()))
           {
               CreateExtras(description, price, isActive);
               MessageBox.Show("Extras created successfully");
           }
           else 
           {                
               MessageBox.Show("Please fill all the fields");
           }
        }

        public bool CreateExtras(string description, double price, bool active)
        {
            try
            {
                models.Extra extras = new models.Extra();
                extras.Description = description;
                extras.Price = price;
                extras.Active = active;
                base.context.Extras.Add(extras);
                base.context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }   

    }
}
