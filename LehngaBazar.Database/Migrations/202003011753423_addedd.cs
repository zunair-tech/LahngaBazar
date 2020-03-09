namespace LehngaBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "category_ID", "dbo.Categories");
            DropForeignKey("dbo.Products", "Product_ID", "dbo.Products");
            DropIndex("dbo.Categories", new[] { "category_ID" });
            DropIndex("dbo.Products", new[] { "Product_ID" });
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "category_ID", c => c.Int());
            CreateIndex("dbo.Products", "category_ID");
            AddForeignKey("dbo.Products", "category_ID", "dbo.Categories", "ID");
            DropColumn("dbo.Categories", "Price");
            DropColumn("dbo.Categories", "category_ID");
            DropColumn("dbo.Products", "Product_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Product_ID", c => c.Int());
            AddColumn("dbo.Categories", "category_ID", c => c.Int());
            AddColumn("dbo.Categories", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Products", "category_ID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_ID" });
            DropColumn("dbo.Products", "category_ID");
            DropColumn("dbo.Products", "Price");
            CreateIndex("dbo.Products", "Product_ID");
            CreateIndex("dbo.Categories", "category_ID");
            AddForeignKey("dbo.Products", "Product_ID", "dbo.Products", "ID");
            AddForeignKey("dbo.Categories", "category_ID", "dbo.Categories", "ID");
        }
    }
}
