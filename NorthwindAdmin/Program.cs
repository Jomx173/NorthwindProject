using DataAccess.Extensions;
using DataAccess.Repository.EmployeeRepository;
using DataAccess.Repository.VentasEmpleadosRepository;
using Domain.Models.Interfaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NortwindAdmin;
using DataAccess.Repository;
using Domain.Interfaces;

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

                    // Repositorios e interfaces
                    services.AddTransient<IEmployee, EmployeeRepository>();
                    services.AddTransient<IVentasEmpleados, VentasEmpleadosRepository>();
                    services.AddScoped<IOrder, OrderRepository>();
                    services.AddScoped<Domain.Interfaces.ICategory, CategoryRepository>();
                    services.AddScoped<IProduct, ProductRepository>();
                    services.AddScoped<ISupplier, SupplierRepository>();


                    // Servicios
                    services.AddScoped<CustomerService>();
                    services.AddScoped<OrderService>();
                    services.AddScoped<CategoryService>();
                    services.AddScoped<ProductService>();
                    services.AddScoped<SupplierService>();
                    services.AddTransient<ReportService>();
                    services.AddTransient<EmpleadosService>();
                    services.AddTransient<VentasEmpleadosServices>();

              
                    // Formularios
                    services.AddTransient<FrmEmpleados>();
                    services.AddTransient<Form1>();
                    services.AddTransient<FrmProductos>();
                    services.AddTransient<FrmCategorias>();
                    services.AddTransient<FrmProveedores>();
                    services.AddTransient<FrmClientes>();
                    services.AddTransient<FrmMenuGestiones>();
                    services.AddTransient<FrmMenuReportes>();
                    services.AddTransient<FrmVentasEmpleados>();
                    services.AddTransient<FrmSalesByCustomerReport>();
                    services.AddTransient<FrmMenuPrincipal>();
                    services.AddTransient<FrmDashboard>();
                })
                .Build();

            host.Start();

            ServiceProvider = host.Services;

            Application.Run(
                host.Services.GetRequiredService<FrmMenuPrincipal>()
            );
        }
    }
}