using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirst.Filters;

namespace EFDBFirst.Areas.Manager.Controllers
{
    [ManagerAuthorization]
    public class HomeController : Controller
    {
        // GET: Manager/Home/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}