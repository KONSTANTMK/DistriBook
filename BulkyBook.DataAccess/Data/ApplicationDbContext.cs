﻿using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;


namespace BulkyBook.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<CoverTypeModel> CoverTypes { get; set; }
}