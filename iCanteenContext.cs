using iCantina.models;
using System.Data.Entity;

namespace iCantina
{
	public class iCanteenContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<InvoiceLine> InvoiceLines { get; set; }
		public DbSet<Dish> Dishes { get; set; }
		public DbSet<Extra> Extras { get; set; }
		public DbSet<Penalty> Penalties { get; set; }
		public DbSet<Reservation> Reservations { get; set; }

		public iCanteenContext()
		{
			this.Configuration.LazyLoadingEnabled = false;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{				
			base.OnModelCreating(modelBuilder);
		}
	}
}
