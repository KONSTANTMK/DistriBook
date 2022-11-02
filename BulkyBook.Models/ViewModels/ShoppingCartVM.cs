using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCartModel> ListCart { get; set; }
        public OrderHeaderModel OrderHeader { get; set; }
    }
}
