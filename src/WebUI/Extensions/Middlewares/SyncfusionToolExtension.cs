using System;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Syncfusion.Blazor;
using Microsoft.Extensions.Configuration;

namespace GFCA.WebUI.Extensions.Middlewares
{

    public static class SyncfusionToolExtension
    {
        //license for version : 18.2.0.44
        //license for project Name : CocoMax
        //private const string lic = "Mjk5NjYwQDMxMzgyZTMyMmUzMFFOSkxxVkkxUXY1VWF3Y3Y2aS9icHRMajV3cG1aZ3JSM3ZqcnJOdkl1MFk9;Mjc2MzM1QDMxMzgyZTMxMmUzMFJBa0Mza24wSlA2LzBoeFVUVW9QcVNOR3poVzJzRTFpZFhZbGl4Y0g4VUU9";
        //license for version : 18.3.0.35
        //license for project Name : [blank]
        private const string lic = "MzMwNzMxQDMxMzgyZTMzMmUzMGhObkdUV0xscFhPMmpSdzNiUi9pQmVLa3NQRFVTOFRhdHN4OHlJMmZIZ1U9;MzMwNzMyQDMxMzgyZTMzMmUzMEVGSjUwdTZldmtPT0M1bUFyc3RHb1FxU1ZkY2w1d3lldmFmc0lycDlrd2s9;MzMwNzMzQDMxMzgyZTMzMmUzMGRHWE1qYW0zRmYzM2JvM2ZoSHVyTEFJOW9NSWUzOGpuVVZ5b2gzVE5IOEU9;MzMwNzM0QDMxMzgyZTMzMmUzMGlRZTVSYUw0TjJ4T08va0JjY2NjZm9HUUZBbktnRkV3RjBPbXNXWDZ0REk9";
        public static IServiceCollection AddSyncfusionTool(this IServiceCollection services, IConfiguration configuration, bool disableScriptManager = false)
        {
            services.AddSyncfusionBlazor(disableScriptManager);
            services.AddServiceEndpoint(configuration);
            services.AddServicePages();
            return services;
        }
        public static IApplicationBuilder UseSyncfusionTool(this IApplicationBuilder app)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(lic);
            app.UseRequestLocalization(app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value);

            /*
            //Microsoft.AspNetCore.Http.Abstractions
            //Microsoft.AspNetCore.Proxy
            app.MapWhen(
                context => context.Request.Path.StartsWithSegments("/api"),
                builder => builder.RunProxy(new ProxyOptions
                {
                    Scheme = "http",
                    Host = "localhost",
                    Port = "5001"
                }));
            */
            return app;
        }

        private static IServiceCollection AddServiceEndpoint(this IServiceCollection services, IConfiguration configuration)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true;


            var baseUri = configuration.GetValue<string>("ApiEndpoint:Uri");
            services.AddSingleton(new HttpClient(httpClientHandler) { BaseAddress = new Uri(baseUri) });
            return services;
        }
        private static IServiceCollection AddServicePages(this IServiceCollection services)
        {
            services.AddScoped<GFCA.WebUI.Pages.MyInbox.DocumentService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Accountants.CostCenters.CostCenterService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Accountants.GLAccounts.GLAccountService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Accountants.GLGroups.GLGroupService>();

            services.AddScoped<GFCA.WebUI.Pages.Masters.BusinessParties.Customers.CustomerService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.BusinessParties.Suppliers.SupplierService>();

            services.AddScoped<GFCA.WebUI.Pages.Masters.Documents.BudgetTypes.BudgetTypeService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Documents.DocumentTypes.DocumentTypeService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Documents.DocumentTypes.WorkflowService>();

            services.AddScoped<GFCA.WebUI.Pages.Masters.Organizations.Companies.CompanyService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Organizations.Departments.DepartmentService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Organizations.Employees.EmployeeService>();

            services.AddScoped<GFCA.WebUI.Pages.Masters.Warehouses.Brands.BrandService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Warehouses.Products.ProductService>();
            
            services.AddScoped<GFCA.WebUI.Pages.Masters.Sales.Channels.ChannelService>();
            services.AddScoped<GFCA.WebUI.Pages.Masters.Sales.TradeActivityService>();
            //services.AddScoped<GFCA.WebUI.Pages.Masters.ShipToPage.ShipToAdaptor>();

            services.AddTransient<GFCA.WebUI.Services.HelperService>();
            return services;
        }

    }
}
