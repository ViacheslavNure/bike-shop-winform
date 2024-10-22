using AutoMapper;
using BikeShop.Application.Mapper;
using BikeShop.Data.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WinFormApplication = System.Windows.Forms.Application;

namespace BikeShop.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName)
                .AddJsonFile("appsettings.json")
                .Build();

            var services = new ServiceCollection();
            services.AddDataLayer(configuration);
            services.AddApplicationLayer();
            services.AddAutoMapper(Assembly.GetAssembly(typeof(EntityToViewMappingProfile)));

            using var serviceProvider = services.BuildServiceProvider();

            WinFormApplication.Run(new Form1(serviceProvider));
        }
    }
}