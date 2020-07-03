using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unisource.Models
{
    public class ProductImage
    {
        [Key]
        public int imageId { get; set; }
        public string  imageurl { get; set; }
        public DateTime DateTime { get; set; }
        public bool status { get; set; }
        public int Product_Id { get; set; }
        public virtual Product Product { get; set; }
    }
}