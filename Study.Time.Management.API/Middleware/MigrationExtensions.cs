using Microsoft.AspNetCore.Builder;

namespace Study.Time.Management.API.Middleware
{
    public static class MigrationExtensions
    {
        public static IApplicationBuilder UseMigration(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MigrationMiddleware>();
        }
    }
}
