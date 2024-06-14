using iCantina.models;
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

        public bool CreateExtra(string description, float price, bool isActive) 
        {
            try
            {
                models.Extra extras = new models.Extra();
                extras.Description = description;
                extras.Price = price;
                extras.Active = isActive;
                base.context.Extras.Add(extras);
                base.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditExtra(int extraId, string description, float price, bool isActive)
        {
			try
            {
                Extra extra = base.context.Extras.Find(extraId);
				extra.Description = description;
				extra.Price = price;
				extra.Active = isActive;
				base.context.SaveChanges();
				return true;
			}
			catch (Exception ex)
            {
				return false;
			}
		}

        public bool DeleteExtra(int extraId)
        {
            try
            {
				Extra extra = base.context.Extras.Find(extraId);
				base.context.Extras.Remove(extra);
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
