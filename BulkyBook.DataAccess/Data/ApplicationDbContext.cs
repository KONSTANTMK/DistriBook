using BulkyBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BulkyBook.DataAccess;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<CoverTypeModel> CoverTypes { get; set; }
    public DbSet<ProductModel> Products { get; set; }
}
