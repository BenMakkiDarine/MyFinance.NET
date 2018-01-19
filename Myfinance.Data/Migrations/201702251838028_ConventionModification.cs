namespace Myfinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConventionModification : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "DateProduction", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Products", "address_StreetAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.Providers", "DateCreated", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Providers", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "address_StreetAddress", c => c.String());
            AlterColumn("dbo.Products", "DateProduction", c => c.DateTime(nullable: false));
        }
    }
}
