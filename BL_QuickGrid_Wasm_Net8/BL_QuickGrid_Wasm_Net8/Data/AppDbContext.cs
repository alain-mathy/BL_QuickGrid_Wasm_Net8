using BL_QuickGrid_Wasm_Net8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BL_QuickGrid_Wasm_Net8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
