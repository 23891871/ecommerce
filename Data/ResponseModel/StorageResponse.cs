using Data.Data;

namespace Data.ResponseModel
{
    public class StorageResponse
    {
        public string StatusCode { get; set; } = default!;
        public string? Description { get; set; }
        public Storage? Storage { get; set; }
        public List<Storage>? Storages { get; set; }
    }
}
