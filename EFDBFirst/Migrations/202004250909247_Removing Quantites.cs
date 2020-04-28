﻿namespace EFDBFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingQuantites : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}