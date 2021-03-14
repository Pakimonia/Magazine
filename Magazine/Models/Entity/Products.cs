using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Magazine.Models.Entity
{
    [Table("tblProducts")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Info { get; set; }
        [Required]
        public string CountryProducer { get; set; }

        [Required]
        public string Image_URL { get; set; }
    }
}