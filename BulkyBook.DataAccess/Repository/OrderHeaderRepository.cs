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
    public class OrderHeaderRepository : Repository<OrderHeaderModel>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;


        public OrderHeaderRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }


        public void Update(OrderHeaderModel obj)
        {
            _db.OrderHeaders.Update(obj);
        }

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);

            if (orderFromDb != null)
            {
                orderFromDb.OrderStatus=orderStatus;
                if(paymentStatus != null)
                {
                    orderFromDb.PaymentStatus=paymentStatus;
                }
            }
        }
    }
}
