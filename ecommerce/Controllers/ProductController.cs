using Data.Data;
using Data.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Products()
        {
            var prs = await _db.Products.ToListAsync();
            return Ok(new ProductResponse 
                { 
                    StatusCode = "200", 
                    Description = "Success", 
                    Products = prs 
                }
            );
        }

        [HttpGet]
        public async Task<IActionResult> ProductById(string id)
        {
            var pr = await _db.Products.FindAsync(id);
            if (pr == null) 
            { 
                return NotFound(new ProductResponse
                {
                    StatusCode = "404",
                    Description = "Not Found",
                }); 
            }
            return Ok(new ProductResponse
                {
                    StatusCode = "200",
                    Description = "Success",
                    Product = pr
                }
            );
        }

        [HttpPost]
        public async Task<IActionResult> Product(Product product)
        {
            if (product == null) 
            { 
                return BadRequest(new ProductResponse
                {
                    StatusCode = "400",
                    Description = "Invalid product object",
                }); 
            }
            var storage = await _db.Storages.FindAsync(product.StorageId);
            if (storage == null)
            {
                return BadRequest(new ProductResponse
                {
                    StatusCode = "400",
                    Description = "Storage not found",
                });
            }
            product.Storage = storage;
            product.Id = Guid.NewGuid().ToString();
            var res = await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
            return Ok(new ProductResponse
                {
                    StatusCode = "200",
                    Description = "Success",
                    Product = res.Entity
                }
            );
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Product(string id)
        {
            var pr = await _db.Products.FindAsync(id);
            if (pr == null)
            {
                return NotFound(new ProductResponse
                {
                    StatusCode = "400",
                    Description = "Not found by the given id",
                });
            }

            _db.Products.Remove(pr);
            await _db.SaveChangesAsync();
            return Ok(new ProductResponse
            {
                StatusCode = "200",
                Description = "Successfully deleted",
            });
        }
    }
}
