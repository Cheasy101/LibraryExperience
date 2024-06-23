using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using mssql.Data.Domain;

namespace mssql.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server=localhost,1433;Database=YourDatabaseName;User Id=SA;Password=your_password;");
    // }
    //
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<ProductCategory>()
    //         .HasKey(pc => new { pc.ProductId, pc.CategoryId });
    //
    //     modelBuilder.Entity<ProductCategory>()
    //         .HasOne(pc => pc.Product)
    //         .WithMany(p => p.ProductCategories)
    //         .HasForeignKey(pc => pc.ProductId);
    //
    //     modelBuilder.Entity<ProductCategory>()
    //         .HasOne(pc => pc.Category)
    //         .WithMany(c => c.ProductCategories)
    //         .HasForeignKey(pc => pc.CategoryId);
    // }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }
}
