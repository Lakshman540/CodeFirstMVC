using EFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EFDBFirst.ApiControllers
{
    [Authorize(Roles ="Admin")]
    public class BrandsController : ApiController
    {
        public List<Brand> Get()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Brand> brands = db.Brands.ToList();
            return brands;
        }

        public Brand GetBrandByBrandID(long BrandID)
        {
            CompanyDBContext db = new CompanyDBContext();
            Brand existingBrand = db.Brands.Where(temp => temp.BrandID == BrandID).FirstOrDefault();
            return existingBrand;
        }
        public void PostBrand(Brand newBrand)
        {
            CompanyDBContext db = new CompanyDBContext();
            db.Brands.Add(newBrand);
            db.SaveChanges();
        }

        public void PutBrand(Brand brandData)
        {
            CompanyDBContext db = new CompanyDBContext();
            var existingBrand = db.Brands.Where(temp => temp.BrandID == brandData.BrandID).FirstOrDefault();
            existingBrand.BrandName = brandData.BrandName;
            db.SaveChanges();
        }

        public void DeleteBrand(long BrandID)
        {
            CompanyDBContext db = new CompanyDBContext();
            var existingBrand = db.Brands.Where(temp => temp.BrandID == BrandID).FirstOrDefault();
            db.Brands.Remove(existingBrand);
            db.SaveChanges();
        }
    }
}
