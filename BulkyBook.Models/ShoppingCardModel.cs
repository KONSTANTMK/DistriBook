using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class ShoppingCardModel
    {
        public ProductModel Product { get; set; }
        [Range(1, 1000, ErrorMessage = "Please enter a value between 1 to 1000")]
        public int Count { get; set; }
    }
}
