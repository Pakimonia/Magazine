﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Magazine.Models;

namespace Magazine.Models.Entity
{
    [Table("tblUserAdditionalInfo")]
    public class UserAdditionalInfo
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Image { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}