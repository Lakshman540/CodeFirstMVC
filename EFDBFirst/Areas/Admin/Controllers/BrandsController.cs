using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirst.Models;
using EFDBFirst.Filters;

namespace EFDBFirst.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class BrandsController : Controller
    {
        // GET: Admin/Brands
        public ActionResult Index()
        {
            
            return View();
        }
    }
}