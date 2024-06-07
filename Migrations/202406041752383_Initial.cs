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
                        PriceStudent = c.Double(nullable: false),
                        PriceProfessor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Dish_Id = c.Int(),
                        Menu_Id = c.Int(),
                        Penalty_Id = c.Int(),
                        Professor_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Penalties", t => t.Penalty_Id)
                .ForeignKey("dbo.Professors", t => t.Professor_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Dish_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Penalty_Id)
                .Index(t => t.Professor_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Penalties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Balance = c.Single(nullable: false),
                        Name = c.String(),
                        NIF = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Total = c.Single(nullable: false),
                        Professor_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professors", t => t.Professor_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Professor_Id)
                .Index(t => t.Student_Id);
            
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
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentNumber = c.Int(nullable: false),
                        Balance = c.Single(nullable: false),
                        Name = c.String(),
                        NIF = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Name = c.String(),
                        NIF = c.String(),
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
                "dbo.ExtraReservations",
                c => new
                    {
                        Extra_Id = c.Int(nullable: false),
                        Reservation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Extra_Id, t.Reservation_Id })
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .Index(t => t.Extra_Id)
                .Index(t => t.Reservation_Id);
            
            CreateTable(
                "dbo.DishMenus",
                c => new
                    {
                        Dish_Id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Dish_Id, t.Menu_Id })
                .ForeignKey("dbo.Dishes", t => t.Dish_Id, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .Index(t => t.Dish_Id)
                .Index(t => t.Menu_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DishMenus", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.DishMenus", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.ExtraReservations", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.ExtraReservations", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.Reservations", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Invoices", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Reservations", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.Invoices", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.InvoiceLines", "Invoice_Id", "dbo.Invoices");
            DropForeignKey("dbo.Reservations", "Penalty_Id", "dbo.Penalties");
            DropForeignKey("dbo.Reservations", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Reservations", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.ExtraMenus", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.ExtraMenus", "Extra_Id", "dbo.Extras");
            DropIndex("dbo.DishMenus", new[] { "Menu_Id" });
            DropIndex("dbo.DishMenus", new[] { "Dish_Id" });
            DropIndex("dbo.ExtraReservations", new[] { "Reservation_Id" });
            DropIndex("dbo.ExtraReservations", new[] { "Extra_Id" });
            DropIndex("dbo.ExtraMenus", new[] { "Menu_Id" });
            DropIndex("dbo.ExtraMenus", new[] { "Extra_Id" });
            DropIndex("dbo.InvoiceLines", new[] { "Invoice_Id" });
            DropIndex("dbo.Invoices", new[] { "Student_Id" });
            DropIndex("dbo.Invoices", new[] { "Professor_Id" });
            DropIndex("dbo.Reservations", new[] { "Student_Id" });
            DropIndex("dbo.Reservations", new[] { "Professor_Id" });
            DropIndex("dbo.Reservations", new[] { "Penalty_Id" });
            DropIndex("dbo.Reservations", new[] { "Menu_Id" });
            DropIndex("dbo.Reservations", new[] { "Dish_Id" });
            DropTable("dbo.DishMenus");
            DropTable("dbo.ExtraReservations");
            DropTable("dbo.ExtraMenus");
            DropTable("dbo.Employees");
            DropTable("dbo.Students");
            DropTable("dbo.InvoiceLines");
            DropTable("dbo.Invoices");
            DropTable("dbo.Professors");
            DropTable("dbo.Penalties");
            DropTable("dbo.Reservations");
            DropTable("dbo.Extras");
            DropTable("dbo.Menus");
            DropTable("dbo.Dishes");
        }
    }
}
