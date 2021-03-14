using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Magazine.Areas.AdminPanel.Models
{
    public class AdminViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
    public class CreateAdminViewModel
    {
        [Required]
        public string FullName { get; set; }
    }
}