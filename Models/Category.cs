using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unisource.Models
{
    public class Category
    {
        [Key]
        public int CategoreyID { get; set; }
        public string Categorey_Name { get; set; }
        public bool Status { get; set; }

    }
}