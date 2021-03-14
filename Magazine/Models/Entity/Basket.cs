using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Magazine.Models.Entity
{
    [Table("tblBaskets")]
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public List<Products> Products { get; set; }
        public int BayerId { get; set; }
    }
}