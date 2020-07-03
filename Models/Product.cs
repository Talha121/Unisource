using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unisource.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public float Orignal_Price { get; set; }
        public float Discounted_Price { get; set; }

        public int CategoreyID { get; set; }
        public virtual Category Category { get; set; }
        public bool Status { get; set; }
        public DateTime DateTime { get; set; }
    }
}