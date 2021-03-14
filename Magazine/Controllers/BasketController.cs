using Magazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class BasketController : Controller
    {
        private ApplicationDbContext _context;
        public BasketController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Basket
        public ActionResult Index()
        {
            return View();
        }

    }
}