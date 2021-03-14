using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }
        public string CountryProducer { get; set; }
        public string Image_URL { get; set; }
    }
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }
        public string CountryProducer { get; set; }
        public string Image_URL { get; set; }
    }
}