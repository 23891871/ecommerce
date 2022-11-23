

using System.ComponentModel.DataAnnotations;

namespace Data.Data
{
    public class Product
    {
        [Key]
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!; // Primary Key
        public double Price { get; set; } 
        public string Description { get; set; } = default!;
        public string? StorageId { get; set; } // Foreign Key
        public Storage? Storage { get; set; } // Foreign Key
    }
}
