using OnionArch.Domain.Entities;

namespace OnionArch.Application.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
