using OnionArch.Application.Interfaces;
using OnionArch.Domain.Entities;

namespace OnionArch.Persistence.Concretes
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories() => new()
        {
            new() { Id = Guid.NewGuid(), Name = "Category 1", Description="Category 1", CreatedAt=DateTime.Now},
            new() { Id = Guid.NewGuid(), Name = "Category 2", Description="Category 2", CreatedAt=DateTime.Now},
            new(){ Id = Guid.NewGuid(), Name = "Category 3", Description="Category 3", CreatedAt=DateTime.Now},
            new() { Id = Guid.NewGuid(), Name = "Category 4", Description="Category 4", CreatedAt=DateTime.Now},
            new() { Id = Guid.NewGuid(), Name = "Category 5", Description="Category 5", CreatedAt=DateTime.Now}
        };
    }
}
