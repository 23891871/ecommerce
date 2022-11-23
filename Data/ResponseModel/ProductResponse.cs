using Data.Data;

namespace Data.ResponseModel
{
    public class ProductResponse
    {
        public string StatusCode { get; set; } = default!;
        public string? Description { get; set; }
        public Product? Product { get; set; }
        public List<Product>? Products { get; set; }
    }
}
