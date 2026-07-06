using Data_access.Service;
using Data_access.Repository.VentasEmpleadosRepository;
using Domain.Models.Intefaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NorthwinAdmin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDataAccess(context.Configuration);

                    services.AddTransient<CustomerServices>();

                    services.AddTransient<IVentasEmpleados, VentasEmpleadosRepository>();
                    services.AddTransient<VentasEmpleadosServices>();

                    services.AddTransient<FrmVentasEmpleados>();
                })
                .Build();

            var mainForm = host.Services.GetRequiredService<FrmVentasEmpleados>();
            Application.Run(mainForm);
        }
    }
}