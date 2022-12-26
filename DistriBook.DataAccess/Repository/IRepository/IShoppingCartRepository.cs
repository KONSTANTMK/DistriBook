using DistriBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriBook.DataAccess.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCartModel>
    {
        int IncrementCount(ShoppingCartModel shoppingCart, int count);
        int DecrementCount(ShoppingCartModel shoppingCart, int count);

    }
}
