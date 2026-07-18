using DataAccess.Extensions;
using DataAccess.Repository.EmployeeRepository;
using Domain.Models.Intefaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
                    // Acceso a datos
                    services.AddDataAccess(context.Configuration);

                    // Servicios
                    services.AddScoped<CustomerService>();
                    services.AddTransient<IEmployees, EmployeeRepository>();
                    services.AddTransient<EmployeesServices>();

                    // Formularios
                    services.AddTransient<FrmEmpleados>();
                    services.AddTransient<FrmMenuGestiones>();
                    services.AddTransient<FrmMenuReportes>();
                    services.AddTransient<FrmCategorias>();
                })
                .Build();

            host.Start();

            ServiceProvider = host.Services;

            Application.Run(
                host.Services.GetRequiredService<FrmMenuGestiones>());
        }
    }
}