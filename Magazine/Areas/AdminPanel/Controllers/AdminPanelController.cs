using Magazine.Models;
using Magazine.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Areas.AdminPanel.Controllers
{
    public class AdminPanelController : Controller
    {
        private ApplicationDbContext _context;
        public AdminPanelController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: AdminPanel/AdminPanel
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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult Create(CreateProductViewModel model)
        {
            _context.Products.Add(new Products
            {
                Name = model.Name,
                Price = model.Price,
                Info = model.Info,
                CountryProducer = model.CountryProducer,
                Image_URL = model.Image_URL

            });
            _context.SaveChanges();
            return RedirectToAction("Index", "AdminPanel");
        }
        [HttpGet]
        [Authorize]
        public ActionResult Edit(int id)
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
                return RedirectToAction("Index", "AdminPanel");
            }
        }
        [HttpPost]
        [Authorize]
        public ActionResult Edit(ProductViewModel model)
        {
            var edit = _context.Products.FirstOrDefault(t => t.Id == model.Id);
            if (edit != null)
            {
                edit.Name = model.Name;
                edit.Price = model.Price;
                edit.Info = model.Info;
                edit.CountryProducer = model.CountryProducer;
                edit.Image_URL = model.Image_URL;
                _context.SaveChanges();
                return RedirectToAction("Index", "AdminPanel");
            }
            else
            {
                return RedirectToAction("Index", "AdminPanel");
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

                var del = _context.Products.FirstOrDefault(p => p.Id == id);
                if (del != null)
                {
                    _context.Products.Remove(del);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "AdminPanel");
                }
                else
                {
                    return RedirectToAction("Index", "AdminPanel");
                }
        }
    }
}