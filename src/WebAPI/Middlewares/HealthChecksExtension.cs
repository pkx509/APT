using System;
using GFCA.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HealthChecks.UI.Core;
using HealthChecks.UI.Client;

namespace GFCA.WebAPI.Middlewares
{
    public static class HealthChecksExtension
    {
        public static IServiceCollection AddCustomHealthCheck(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:DefaultConnection"];
            
            services.AddHealthChecks()
                .AddDbContextCheck<ApplicationDbContext>()
                .AddSqlServer(
                    connectionString: connectionString,
                    healthQuery: "select 1",
                    name: "AsiaticAPTDb-check",
                    failureStatus: Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Degraded,
                    tags: new string[] { "AsiaticAPTDb" }
                );
            
            return services;
        }

        public static void CustomUseHealthChecks(this IApplicationBuilder app)
        {

            //app.UseHealthChecks("/hc");
            //app.UseHealthChecksUI(o => o.UIPath = "/hc-ui");
            
            app
                .UseRouting()
                .UseEndpoints(confg =>
                {
                    
                    confg.MapHealthChecks("/hc", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions()
                    {
                        Predicate = _ => true,
                        ResponseWriter = HealthChecks.UI.Client.UIResponseWriter.WriteHealthCheckUIResponse
                    });
                    
                    confg.MapHealthChecksUI(o => o.UIPath = "/hc-ui" );
                });
            
        }

    }
}
