using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirst.Models;
using EFDBFirst.Filters;

namespace EFDBFirst.Controllers
{
    //[MyAuthenticationFilter]
   // [CustomerAuthorization]
    //[MyActionFilter]
    [OutputCache(Duration =60)]
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}