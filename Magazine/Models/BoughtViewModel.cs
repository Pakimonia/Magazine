using Magazine.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Models
{
    public class BoughtViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public List<SelectListItem> Products { get; set; }
    }
    public class CreateBoughtViewModel
    {
        public string ProductName { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public List<SelectListItem> Products { get; set; }
    }
}