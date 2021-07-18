using System;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
//using BlazorState;

namespace GFCA.WebUI.Components.AdminLte
{
    public static class AdminLteExtension
    {
        public static IServiceCollection AddAdminLte(this IServiceCollection services)
        {
            services
            .AddScoped<NavBarLeftInjectableMenu>()
            /*.AddBlazorState(options => 
                options.Assemblies = new Assembly[]
                {
                    typeof(BaseClasses).GetTypeInfo().Assembly,
                    Assembly.GetExecutingAssembly()
                })
            */
            .AddScoped<ILayoutManager, LayoutManager>()
            ;
            return services;
        }
    }
}
