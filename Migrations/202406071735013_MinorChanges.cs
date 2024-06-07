namespace iCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinorChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DishMenus", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.DishMenus", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.DishMenus", new[] { "Dish_Id" });
            DropIndex("dbo.DishMenus", new[] { "Menu_Id" });
            AddColumn("dbo.Menus", "Dish_Id", c => c.Int());
            CreateIndex("dbo.Menus", "Dish_Id");
            AddForeignKey("dbo.Menus", "Dish_Id", "dbo.Dishes", "Id");
            DropTable("dbo.DishMenus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DishMenus",
                c => new
                    {
                        Dish_Id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Dish_Id, t.Menu_Id });
            
            DropForeignKey("dbo.Menus", "Dish_Id", "dbo.Dishes");
            DropIndex("dbo.Menus", new[] { "Dish_Id" });
            DropColumn("dbo.Menus", "Dish_Id");
            CreateIndex("dbo.DishMenus", "Menu_Id");
            CreateIndex("dbo.DishMenus", "Dish_Id");
            AddForeignKey("dbo.DishMenus", "Menu_Id", "dbo.Menus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DishMenus", "Dish_Id", "dbo.Dishes", "Id", cascadeDelete: true);
        }
    }
}
