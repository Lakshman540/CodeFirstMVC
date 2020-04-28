namespace EFDBFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDBFirst.Models.CompanyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EFDBFirst.Models.CompanyDBContext";
        }

        protected override void Seed(EFDBFirst.Models.CompanyDBContext context)
        {
            context.Brands.AddOrUpdate(new Models.Brand() { BrandID = 1, BrandName = "Samsung" });
            context.Categories.AddOrUpdate(new Models.Category() { CategoryID = 1, CategoryName = "Electronics" });
            context.Products.AddOrUpdate(new Models.Product() { ProductID = 1, ProductName = "Samung Galaxy", CategoryID = 1, DOP = DateTime.Now, Active = true, BrandID = 1, Photo = null, Price = 10000, AvailabilityStatus = "InStock" });
        }
    }
}
