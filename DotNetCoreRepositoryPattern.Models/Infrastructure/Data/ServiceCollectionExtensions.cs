using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreRepositoryPattern.Models.Infrastructure.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UniversityContext>(options =>
                    options.UseSqlServer(connectionString));
        }
    }
}
