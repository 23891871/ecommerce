# Ecommerce499

Ecommerce499 is a backend Restful API server.


## Features

- Create, read and delete products.
- Create storages.


## Endpoints
- [GET] [api/Product/Products] - Return all products in the database.
- [GET] [api/Product/Product] - Find a product by id and return the product if it exists.
- [POST] [api/Product/Product] - Create a product with a given object.
- [DELETE] [api/Product/Product] - Delete a product by id.
- [POST] [api/Storage/Storage] - Create a storage with a given object.

## Sample request bodies
- [GET] [api/Product/Products]
```json
{ }
```

- [GET] [api/Product/Product?id=wtnkjdnfj-sdfk32432-gfdg454]
```json
{ }
```

- [POST] [api/Product/Product]
```json
{
  "name": "string",
  "price": 0,
  "description": "string",
  "storageId": "string"
}
```

- [DELETE] [api/Product/Product?id=wtnkjdnfj-sdfk32432-gfdg454]
```json
{ }
```

- [POST] [api/Storage/Storage]
```json
{
  "id": "string",
  "name": "string",
  "owner": "string",
  "address": "string"
}
```

## Sample response body
class
```cs
    public class ProductResponse
    {
        public string StatusCode { get; set; } = default!;
        public string? Description { get; set; }
        public Product? Product { get; set; }
        public List<Product>? Products { get; set; }
    }
    
    public class StorageResponse
    {
        public string StatusCode { get; set; } = default!;
        public string? Description { get; set; }
        public Storage? Storage { get; set; }
        public List<Storage>? Storages { get; set; }
    }
```

Example
```json
{
  "statusCode": "200",
  "description": "Success",
  "product": null,
  "products": []
}
```


## License

MIT

