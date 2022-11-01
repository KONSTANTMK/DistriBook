﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUserModel>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;


        public ApplicationUserRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }

    }
}
