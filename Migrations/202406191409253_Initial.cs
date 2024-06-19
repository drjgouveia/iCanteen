namespace iCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "Menu_Id", c => c.Int());
            CreateIndex("dbo.Invoices", "Menu_Id");
            AddForeignKey("dbo.Invoices", "Menu_Id", "dbo.Menus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.Invoices", new[] { "Menu_Id" });
            DropColumn("dbo.Invoices", "Menu_Id");
        }
    }
}
