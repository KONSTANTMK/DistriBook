using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCartModel>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;


        public ShoppingCartRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }


        public void Update(ShoppingCartModel obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
