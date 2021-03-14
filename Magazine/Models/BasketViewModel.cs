using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Models
{
    public class BasketViewModel
    {
        public int Id { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public int BayerId { get; set; }
    }
    public class CreateBasketViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public int BayerId { get; set; }
    }
}