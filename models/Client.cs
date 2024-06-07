using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Client : User
    {
        public float Balance { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        public Client() {
            Invoices = new List<Invoice>();
            Balance = 0;
        }

        public Client(string name, string nif, float balance) : base(name, nif)
        {
            Invoices = new List<Invoice>();
            Balance = balance;
        }

        public override string ToString()
        {
			return NIF + " - " + Name + " - " + Balance;
		}
    }
}
