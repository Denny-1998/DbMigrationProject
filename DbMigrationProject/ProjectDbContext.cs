using DbMigrationProject.Models;
using Microsoft.EntityFrameworkCore;


public class ProjectDbContext : DbContext
{
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductRating> ProductRatings { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
        .Property(p => p.Price)
        .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<ProductRating>()
        .HasOne(pr => pr.Product)            // Each ProductRating has one Product
        .WithMany(p => p.ProductRatings)    // A Product can have many ProductRatings
        .HasForeignKey(pr => pr.ProductId);
    }
}
