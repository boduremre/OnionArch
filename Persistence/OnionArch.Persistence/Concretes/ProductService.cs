using OnionArch.Application.Interfaces;
using OnionArch.Domain.Entities;

namespace OnionArch.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new Product { Id = Guid.NewGuid(), Name = "Product 1", Price=100, Stock=10, CreatedAt=DateTime.Now},
            new Product { Id = Guid.NewGuid(), Name = "Product 2", Price=50, Stock=5, CreatedAt=DateTime.Now},
            new Product { Id = Guid.NewGuid(), Name = "Product 3", Price=12, Stock=7, CreatedAt=DateTime.Now},
            new Product { Id = Guid.NewGuid(), Name = "Product 4", Price=45, Stock=100, CreatedAt=DateTime.Now},
            new Product { Id = Guid.NewGuid(), Name = "Product 5", Price=36, Stock=85, CreatedAt=DateTime.Now}
        };
    }
}
