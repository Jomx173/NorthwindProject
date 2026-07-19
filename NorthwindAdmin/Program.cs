using DataAccess.Extensions;
using DataAccess.Repository.EmployeeRepository;
using Domain.Models.Intefaces;
using Domain.Services;
using DataAccess.Repository.VentasEmpleadosRepository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace NorthwindAdmin
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Registrar acceso a datos
                    services.AddDataAccess(context.Configuration);

                    // Servicios
                    services.AddScoped<CustomerService>();
                    services.AddTransient<ReportService>();
                    services.AddTransient<EmployeesServices>();
                    services.AddTransient<VentasEmpleadosServices>();
                    services.AddTransient<IVentasEmpleados, VentasEmpleadosRepository>();

                    // Empleados
                    services.AddTransient<IEmployees, EmployeeRepository>();
                    services.AddTransient<CustomerService>();
                    services.AddTransient<EmployeesServices>();

                    // Formularios
                    services.AddTransient<FrmEmpleados>();
                    services.AddTransient<FrmProductos>();
                    services.AddTransient<FrmMenuGestiones>();
                    services.AddTransient<FrmMenuReportes>();
                    services.AddTransient<ReportService>();
                    services.AddTransient<VentasEmpleadosServices>();
                    services.AddTransient<FrmSalesByCustomerReport>();
                    services.AddTransient<FrmMenuPrincipal>();
                })
                .Build();

            host.Start();

            ServiceProvider = host.Services;

            Application.Run(host.Services.GetRequiredService<FrmMenuPrincipal>());
        }
    }
}