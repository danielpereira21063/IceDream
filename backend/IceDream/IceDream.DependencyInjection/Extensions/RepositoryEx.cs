using IceDream.Data.Repositories;
using IceDream.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IceDream.DependencyInjection.Extensions
{
    internal static class RepositoryEx
    {
        internal static void AddRepositories(this IServiceCollection services)
        {
            services.AddScopedRepositories();
        }

        private static void AddScopedRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
        }
    }
}
