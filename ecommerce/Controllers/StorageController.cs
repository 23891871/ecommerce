using Data.Data;
using Data.ResponseModel;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StorageController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> PostStorage(Storage storage)
        {
            if (storage == null)
            {
                return BadRequest(new StorageResponse
                {
                    StatusCode = "400",
                    Description = "Invalid storage object",
                });
            }
            var res = await _db.Storages.AddAsync(storage);
            await _db.SaveChangesAsync();
            return Ok(new StorageResponse
            {
                StatusCode = "200",
                Description = "Success",
                Storage = res.Entity
            }
            );
        }
    }
}
