using DistriBook.DataAccess.Repository.IRepository;
using DistriBook.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<CategoryModel>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;


        public CategoryRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }


        public void Update(CategoryModel obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
