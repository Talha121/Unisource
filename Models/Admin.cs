using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unisource.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact  { get; set; }
        public string Password { get; set; }
        public DateTime DateTime { get; set; }
        public bool Status { get; set; }
    }
}