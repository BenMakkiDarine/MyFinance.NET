namespace Myfinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApiModification : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            RenameTable(name: "dbo.ProviderProducts", newName: "Providing");
            DropPrimaryKey("dbo.Providing");
            AddColumn("dbo.Products", "TypeOfProduct", c => c.String(maxLength: 128));
            AlterColumn("dbo.MyCategories", "Name", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Providing", new[] { "Product_ProductId", "Provider_Id" });
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Providing");
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            DropColumn("dbo.Products", "TypeOfProduct");
            AddPrimaryKey("dbo.Providing", new[] { "Provider_Id", "Product_ProductId" });
            RenameTable(name: "dbo.Providing", newName: "ProviderProducts");
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
        }
    }
}
