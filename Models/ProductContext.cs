using Microsoft.EntityFrameworkCore;
using RemaApp2020.Models;

namespace RemaApp2020.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
            {
            
            }

            public DbSet<Product> Products { get; set; }

            public DbSet<RemaApp2020.Models.Category> Category { get; set; }

    }
}
