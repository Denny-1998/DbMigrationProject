namespace DbMigrationProject.Models
{
    public class ProductRating
    {
        public int Id { get; set; } // Primary key
        public int ProductId { get; set; } // Foreign key reference to Product
        public int Rating { get; set; } // Rating value (1-5)
        public string Comment { get; set; } // Optional comment

        public virtual Product Product { get; set; }
    }
}
