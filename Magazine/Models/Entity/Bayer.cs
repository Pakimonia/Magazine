using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Magazine.Models.Entity
{
    [Table("tblBayers")]
    public class Bayer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }

        public List<Boughts> Boughts { get; set; }

        public int BasketId { get; set; }
    }
}