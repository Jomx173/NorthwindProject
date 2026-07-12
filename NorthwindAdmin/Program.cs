using DataAccess.Extensions;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace NorthwindAdmin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using IHost host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                //registrar repositorios
                services.AddDataAccess(context.Configuration);
                //servicio del dominio
                services.AddScoped<CustomerService>();
                //registrar formularios
                services.AddTransient<FrmMenuReportes>();
            }).Build();

            host.Start();
            Application.Run(host.Services.GetRequiredService<FrmMenuReportes>());
        }
    }
}