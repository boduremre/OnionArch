using Microsoft.Extensions.DependencyInjection;
using OnionArch.Application.Interfaces;
using OnionArch.Persistence.Concretes;

namespace OnionArch.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<ICategoryService, CategoryService>();
        }
    }
}
