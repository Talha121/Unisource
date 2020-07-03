using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unisource.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        public int Sizenumber { get; set; }
        public int Product_Id { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public DateTime DateTime { get; set; }

    }
}