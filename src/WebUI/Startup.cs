using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GFCA.WebUI.Extensions.Middlewares;
using GFCA.WebUI.Components.AdminLte;
using GFCA.WebUI.ViewModels;
using Microsoft.AspNetCore.Http;

namespace GFCA.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            /*
            //Production
            services.AddHttpsRedirection(config =>
            {
                config.RedirectStatusCode = StatusCodes.Status308PermanentRedirect;
                config.HttpsPort = 44300;
            });
            */
            //Development
            services.AddHttpsRedirection(config =>
            {
                config.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                //config.HttpsPort = 44300;
            });
            

            services.AddSyncfusionTool(Configuration);
            services.AddAdminLte();
            services.AddViewModels();
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            //services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            //services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSyncfusionTool();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            /*HSTS
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-XSS-Protection", "1; mode=block ");
                context.Response.Headers.Add("Content-Security-Policy", "default-src 'self';");
                context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                await next.Invoke();
            });
            */
            /*
            app.UseHttpsRedirection(options =>
            {
                options.HttpsPort = 6001;
                options.RedirectStatusCode = StatusCode.Status303PermanentRedirect;
            });
            */
            app.UseStaticFiles();

            app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
