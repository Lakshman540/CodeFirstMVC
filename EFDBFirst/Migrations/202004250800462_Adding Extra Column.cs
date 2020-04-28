﻿namespace EFDBFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingExtraColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
