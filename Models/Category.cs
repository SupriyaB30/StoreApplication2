using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreApplication2.Models
{
    public class Category
    {
        public Category()
        {

        }
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


        public virtual ICollection<Product> Products { get; set; } //Navigation Property
    }
}