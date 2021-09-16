using Microsoft.AspNetCore.Http;
using Study.Time.Management.Migration;
using System;
using System.Threading.Tasks;

namespace Study.Time.Management.API.Middleware
{
    public class MigrationMiddleware
    {
        private readonly RequestDelegate _next;

        public MigrationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var migrationExeption = Migrations.ApplyMigrations(Environment.GetEnvironmentVariable("STMDbConnection"));
            if (migrationExeption != null)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync($"<!DOCTYPE html><html><head><meta charset=\"UTF-8\"></head><body><p style=\"color:red;font-size:20px;\">{ migrationExeption}</p></body></html>");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
