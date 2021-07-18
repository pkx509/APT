using System;
using Microsoft.Extensions.DependencyInjection;
using MvvmBlazor.Extensions;

namespace GFCA.WebUI.ViewModels
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            services.AddMvvm();
            services.AddTransient<IndexViewModel>();
            return services;
        }

        
    }
}
