using GFCA.Application.Common.Interfaces;
using GFCA.Infrastructure.Files;
using GFCA.Infrastructure.Identity;
using GFCA.Infrastructure.Persistence;
using GFCA.Infrastructure.Services;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GFCA.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("GFCADb"));
            }
            else
            {
                string connectionName = "DefaultConnection";
                //connectionName = "QASConnection";
                //connectionName = "ProductionConnection";

                var connectionString = configuration.GetConnectionString(connectionName);

                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        connectionString, b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                        )
                    );
            }

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            services.AddIdentityServer4();

            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IIdentityService, IdentityService>();
            //services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();
            
            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.Authority = "http://localhost:5001";
                    options.Audience = "CFGA-Api";
                });

            services.AddAuthentication().AddIdentityServerJwt();

            return services;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {

            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseAuthorization();
            return app;
        }

        private static IServiceCollection AddIdentityServer4(this IServiceCollection services)
        {
            //services.AddDefaultIdentity<ApplicationUser>().AddEntityFrameworkStores<ApplicationDbContext>();
            /*
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;

                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>();
            */
            services.AddIdentity<User, Role>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;

                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddIdentityServer().AddApiAuthorization<User, ApplicationDbContext>();

            return services;
        }
    }
}
