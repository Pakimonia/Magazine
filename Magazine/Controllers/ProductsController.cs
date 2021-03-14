using Magazine.Models;
using Magazine.Models.Entity;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;
        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Products
        [HttpGet]
        public ActionResult Index(string nameToFind = "")
        {

            var data = _context.Products.Select(t => new ProductViewModel
            {
                Id = t.Id,
                Name = t.Name,
                Price = t.Price,
                Info = t.Info,
                CountryProducer = t.CountryProducer,
                Image_URL = t.Image_URL
            }).Where(p => p.Name.ToLower().Contains(nameToFind)).ToList();
            return View(data);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Info(int id)
        {
            var edit = _context.Products.Select(p => new ProductViewModel
            {
                Name = p.Name,
                Price = p.Price,
                Info = p.Info,
                CountryProducer = p.CountryProducer,
                Image_URL = p.Image_URL,
                Id = p.Id

            }).FirstOrDefault(t => t.Id == id);
            if (edit != null)
            {
                return View(edit);
            }
            else
            {
                return RedirectToAction("Index", "Products");
            }
        }
        [HttpGet]
        [Authorize]
        public ActionResult Buy()
        {
            BoughtViewModel model = new BoughtViewModel();
            model.Products = new List<SelectListItem>();
            foreach (var item in _context.Products.Select(p => new ProductViewModel
            {
                Name = p.Name,
                Price = p.Price,
                Info = p.Info,
                CountryProducer = p.CountryProducer,
                Image_URL = p.Image_URL,
                Id = p.Id

            }))
            {
                model.Products.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Name
                }
                );
            }
            return View(model);
        }
        [HttpPost]
        [Authorize]
        public ActionResult Buy(CreateBoughtViewModel model)
        {
            _context.Boughts.Add(new Boughts
            {
                Name = model.Name,
                Addres = model.Addres,
                ProductName = model.ProductName

            });
            _context.SaveChanges();
            return RedirectToAction("Index", "Products");
        }

        [HttpGet]
        public ActionResult Bayes(string nameToFind = "")
        {

            var data = _context.Boughts.Select(t => new BoughtViewModel
            {
                Id = t.Id,
                Name = t.Name,
                Addres = t.Addres,
                ProductName = t.ProductName
            }).Where(p => p.ProductName.ToLower().Contains(nameToFind)).ToList();
            return View(data);
        }

    }






}