using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using Serilog;

namespace GFCA.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.BrowserConsole()
                .CreateLogger();

            Log.Information("Start web assamble in browser!");
            try
            {
                var builder = CreateHostBuilder(args);
                var host = builder.Build();

                host.Run();
                //await host.RunAsync();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An exception occurred while creating the WASM host");

            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);
            var host = builder
                .ConfigureServices((context, services) =>
                {
                    //services.AddHostedService<ApplicationLifetime>();
                    services.Configure<HostOptions>(option =>
                    {
                        option.ShutdownTimeout = System.TimeSpan.FromSeconds(0);
                    });
                })
                /*
                .ConfigureLogging((hostContext, config) =>
                {
                    config.AddConsole();
                    config.AddDebug();
                    config.AddEventLog();
                })
                .UseConsoleLifetime()
                */
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseSetting("https_port", "6000");
                    webBuilder.UseStartup<Startup>();
                });


            return host;
        }

        public static IHostBuilder IISWebHostBuilder(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);
            var host = builder
                .UseEnvironment("Development")
                .ConfigureServices((context, services) =>
                {
                    services.Configure<HostOptions>(option =>
                    {
                        option.ShutdownTimeout = System.TimeSpan.FromSeconds(15);
                    });
                })
                .ConfigureHostConfiguration(config =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    //config.AddJsonFile("hostsetting.json", optional: true);
                    //config.AddEnvironmentVariables(prefix: "PREFIX_");
                    config.AddCommandLine(args);
                })
                .ConfigureLogging((hostContext, config) =>
                {
                    config.AddConsole();
                    config.AddDebug();
                    config.AddEventLog();
                })
                .UseConsoleLifetime()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseSetting(WebHostDefaults.DetailedErrorsKey, "true");
                    webBuilder.PreferHostingUrls(false);
                    //webBuilder.UseSetting("https_port", "6000");
                    webBuilder.UseStartup<Startup>();
                });


            return host;
        }

    }
}
