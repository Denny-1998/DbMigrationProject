using DbMigrationProject.Models;

namespace DbMigrationProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } // Foreign key to Category


        public ICollection<ProductRating> ProductRatings { get; set; } = new List<ProductRating>();

        public Category Category { get; set; }
    }
}

