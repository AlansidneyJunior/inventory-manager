using InventoryService.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.API.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}