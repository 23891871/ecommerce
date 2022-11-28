# Ecommerce499

Ecommerce499 is a backend Restful API server.


## Features

- Create, read and delete products.
- Delete storages.


## Endpoints
- [api/Product/GetProducts] - Return all products in the database.
- [api/Product/GetProductById] - Find a product by id and return the product if it exists.
- [api/Product/CreateProduct] - Create a product with a given object.
- [api/Product/DeleteProduct] - Delete a product by id.


## Sample request bodies
- [api/Product/GetProducts]
```json
{ }
```

- [api/Product/GetProductById]
```json
{
    "id": "wtnkjdnfj-sdfk32432-gfdg454"
}
```

- [api/Product/CreateProduct]
```json
{
  "name": "string",
  "price": 0,
  "description": "string",
  "storageId": "string"
}
```

- [api/Product/DeleteProduct]
```json
{
    "id": "wtnkjdnfj-sdfk32432-gfdg454"
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

