using DbMigrationProject.Models;
using Microsoft.EntityFrameworkCore;

public class ProjectDbContext : DbContext
{
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductRating> ProductRatings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
