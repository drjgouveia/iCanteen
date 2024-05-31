using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class InvoiceLine
    {
        [Key]
        public int Id { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public InvoiceLine() { }

        public InvoiceLine(int quantity, float price, string description)
        {
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
			return Description + " - " + Price + "€";
		}
    }
}
