using Data_access.Service;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace NorthwinAdmin
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

            using IHost host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddDataAccess(context.Configuration);

                services.AddTransient<CustomerServices>();
                services.AddTransient<VentasEmpleadosServices>();

                services.AddTransient<Form1>();
                services.AddTransient<FrmVentasEmpleados>();

            }).Build();

            var mainForm = host.Services.GetRequiredService<FrmVentasEmpleados>();
            Application.Run(mainForm);
        }
    }
}