namespace Myfinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseDeDoneeInitialisation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        DateProduction = c.DateTime(nullable: false),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(),
                        Herbs = c.String(),
                        City = c.String(),
                        LabName = c.String(),
                        StreetAdress = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.category_CategoryId)
                .Index(t => t.category_CategoryId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConfirmPassword = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        Email = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                        Password = c.String(),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProviderProducts",
                c => new
                    {
                        Provider_Id = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Provider_Id, t.Product_ProductId })
                .ForeignKey("dbo.Providers", t => t.Provider_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Provider_Id)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProviderProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.ProviderProducts", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.Products", "category_CategoryId", "dbo.Categories");
            DropIndex("dbo.ProviderProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.ProviderProducts", new[] { "Provider_Id" });
            DropIndex("dbo.Products", new[] { "category_CategoryId" });
            DropTable("dbo.ProviderProducts");
            DropTable("dbo.Providers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
