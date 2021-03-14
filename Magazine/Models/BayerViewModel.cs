using Magazine.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Magazine.Models
{
    public class BayerViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int BasketId { get; set; }
        public List<BoughtViewModel> Boughts { get; set; }
    }
    public class CreateBayerViewModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }
        public int BasketId { get; set; }

        public List<BoughtViewModel> Boughts { get; set; }


    }
}