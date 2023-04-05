using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApi.Domain.Interfaces;
using ProductApi.Infrastructure.DbContexts;
using ProductApi.Infrastructure.Repositories;

namespace ProductApi.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>(options =>
                options.UseInMemoryDatabase("ProductDb"));

            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
