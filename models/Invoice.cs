﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public Client Client { get; set; }
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
        public Menu Menu { get; set; }


        public Invoice()
        {
            InvoiceLines = new List<InvoiceLine>();
        }

        public Invoice(DateTime date, float total)
        {
            Date = date;
            Total = total;
            InvoiceLines = new List<InvoiceLine>();
        }


        public override string ToString()
        {
			return "Invoice: " + Id + " - " + Client.Name + " - " + Date + " - " + Total + " €";
		}
    }
}
