using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    internal interface ICategoryRepository : IRepository<CategoryModel>
    {
        void Update(CategoryModel obj);
        void Save();

    }
}
