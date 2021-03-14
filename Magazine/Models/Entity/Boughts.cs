using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Magazine.Models.Entity
{

    [Table("tblBoughts")]
    public class Boughts
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Addres { get; set; }

        public List<Products> Products { get; set; }
    }
}