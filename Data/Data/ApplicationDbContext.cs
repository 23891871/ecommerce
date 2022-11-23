using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Storage> Storages { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Storage)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.StorageId);
        }
    }
}
