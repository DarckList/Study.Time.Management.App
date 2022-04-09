using Microsoft.Extensions.DependencyInjection;
using Study.Time.Management.Data.Repositories;
using Study.Time.Management.Domain.Contractrs;

namespace Study.Time.Management.API.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
