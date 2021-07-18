using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GFCA.WebAPI.Middlewares
{
    public static class CorsOriginPolicyExtension
    {
        private const string _myAllowOrigins = "_myAllowOrigins";
        public static IServiceCollection AddCorsOriginPolicy(this IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy(_myAllowOrigins, builder =>
                    builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                 );
            });

            return services;
        }

        public static IApplicationBuilder UseCorsOriginPolicy(this IApplicationBuilder app)
        {
            app.UseCors(_myAllowOrigins);
            return app;
        }

    }
}
