using System.Net;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataAccess.Extensions;

namespace NortwindAdmin
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

            using IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // Registrar los repositorios y servicios necesarios para la aplicación
                services.AddDataAccess(context.Configuration);

                // Servicios del Dominio
                services.AddScoped<CustomerService>();
                services.AddScoped<ProductService>();

                // Registrar el formularios
                services.AddTransient<Form1>();

            }).Build();

            var mainform = host.Services.GetRequiredService<Form1>();
            Application.Run(mainform);
        }
    }
}