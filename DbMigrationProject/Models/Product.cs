using DbMigrationProject.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; } // Foreign key to Category
    public Category Category { get; set; }
    public ICollection<ProductRating> Ratings { get; set; }
}
