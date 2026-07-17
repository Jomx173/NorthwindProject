using DataAccess.Extensions;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NortwindAdmin
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
                // Registrar todos los servicios de DataAccess
                services.AddDataAccess(context.Configuration);

                // Servicios del dominio
                services.AddScoped<CustomerService>();
                services.AddScoped<ProductService>();
                services.AddScoped<OrderService>();

                // Formularios
                services.AddTransient<FormClientes>();
                services.AddTransient<FrmProductos>();

            }).Build();

            var provider = host.Services;

            // Puedes cambiar el formulario inicial según el proyecto.
            var mainForm = provider.GetRequiredService<FrmProductos>();

            Application.Run(mainForm);
        }
    }
}