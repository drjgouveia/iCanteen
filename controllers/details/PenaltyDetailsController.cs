using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace iCanteen.controllers.details
{
    public class PenaltyDetailsController : Controller
    {
        public PenaltyDetailsController() : base() 
        { 
            Console.WriteLine("Penalty Details controller initialized.");
        }


        public bool CreatePenalty(int id, float amount, int hours)
        {
            try
            {
                Penalty penalty = new Penalty();
                penalty.Amount = amount;
                penalty.Hours = hours;
                base.context.Penalties.Add(penalty);
                base.context.SaveChanges();
                return true;
            } catch (Exception ex) 
            {

                return false;
            }
        }

        public bool ReadPenalty(int id)
        {

           try
            {
                Penalty penalty = base.context.Penalties.Find(id);
                Console.WriteLine(penalty.ToString());
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdatePenalty(int id, float amount, int hours)
        {
            try
            {
                Penalty penalty = base.context.Penalties.Find(id);
                penalty.Amount = amount;
                penalty.Hours = hours;
                base.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletePenalty(int id)
        {
            try
            {
                Penalty penalty = base.context.Penalties.Find(id);
                base.context.Penalties.Remove(penalty);
                base.context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
    }

}
