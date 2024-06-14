namespace iCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        QuantityAvailable = c.Int(nullable: false),
                        PriceStudent = c.Single(nullable: false),
                        PriceProfessor = c.Single(nullable: false),
                        Dish_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .Index(t => t.Dish_Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Single(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Served = c.Boolean(nullable: false),
                        Client_Id = c.Int(),
                        Dish_Id = c.Int(),
                        Menu_Id = c.Int(),
                        Penalty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Client_Id)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Penalties", t => t.Penalty_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Dish_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Penalty_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NIF = c.String(),
                        Balance = c.Single(),
                        Email = c.String(),
                        StudentNumber = c.Int(),
                        Username = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Total = c.Single(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.InvoiceLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        Description = c.String(),
                        Invoice_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.Invoice_Id)
                .Index(t => t.Invoice_Id);
            
            CreateTable(
                "dbo.Penalties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExtraMenus",
                c => new
                    {
                        Extra_Id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Extra_Id, t.Menu_Id })
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .Index(t => t.Extra_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.ReservationExtras",
                c => new
                    {
                        Reservation_Id = c.Int(nullable: false),
                        Extra_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_Id, t.Extra_Id })
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Extra_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Penalty_Id", "dbo.Penalties");
            DropForeignKey("dbo.Reservations", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.ReservationExtras", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.ReservationExtras", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Users");
            DropForeignKey("dbo.Invoices", "Client_Id", "dbo.Users");
            DropForeignKey("dbo.InvoiceLines", "Invoice_Id", "dbo.Invoices");
            DropForeignKey("dbo.ExtraMenus", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.ExtraMenus", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.Menus", "Dish_Id", "dbo.Dishes");
            DropIndex("dbo.ReservationExtras", new[] { "Extra_Id" });
            DropIndex("dbo.ReservationExtras", new[] { "Reservation_Id" });
            DropIndex("dbo.ExtraMenus", new[] { "Menu_Id" });
            DropIndex("dbo.ExtraMenus", new[] { "Extra_Id" });
            DropIndex("dbo.InvoiceLines", new[] { "Invoice_Id" });
            DropIndex("dbo.Invoices", new[] { "Client_Id" });
            DropIndex("dbo.Reservations", new[] { "Penalty_Id" });
            DropIndex("dbo.Reservations", new[] { "Menu_Id" });
            DropIndex("dbo.Reservations", new[] { "Dish_Id" });
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropIndex("dbo.Menus", new[] { "Dish_Id" });
            DropTable("dbo.ReservationExtras");
            DropTable("dbo.ExtraMenus");
            DropTable("dbo.Penalties");
            DropTable("dbo.InvoiceLines");
            DropTable("dbo.Invoices");
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.Extras");
            DropTable("dbo.Menus");
            DropTable("dbo.Dishes");
        }
    }
}
