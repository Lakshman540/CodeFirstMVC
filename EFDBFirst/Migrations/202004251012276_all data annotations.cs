namespace EFDBFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alldataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Products", "AvailabilityStatus", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "AvailabilityStatus", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
        }
    }
}
