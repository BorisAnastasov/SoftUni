using Microsoft.EntityFrameworkCore;
using ShoppingList.Models;


namespace ShoppingList.Data.Models
{
	public class ShoppingListDbContext : DbContext
    {
        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options)
        : base(options) => Database.EnsureCreated();

        public DbSet<ShoppingList.Models.Product> Products { get; set; }
        public DbSet<ProductNote> ProductNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingList.Models.Product>().HasMany(p => p.ProductNotes).WithOne(r => r.Product);
        }



    }
}
