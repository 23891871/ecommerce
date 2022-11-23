
using System.ComponentModel.DataAnnotations;

namespace Data.Data
{
    public class Storage
    {
        [Key]
        public string Id { get; set; } = default!; // Primary Key
        public string Name { get; set; } = default!; 
        public string Owner { get; set; } = default!;
        public string Address { get; set; } = default!; // Unique Key
        public List<Product> Products { get; set; }
    }
}
