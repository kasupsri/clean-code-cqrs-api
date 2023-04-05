using Microsoft.EntityFrameworkCore;
using ProductApi.Domain.Models;

namespace ProductApi.Infrastructure.DbContexts
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
