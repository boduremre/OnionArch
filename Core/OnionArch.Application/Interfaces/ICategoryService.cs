using OnionArch.Domain.Entities;

namespace OnionArch.Application.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
