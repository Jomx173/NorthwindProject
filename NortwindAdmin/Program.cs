using DataAccess.Context;
using DataAccess.Repository;
using Domain.Interfaces;
using Domain.Models.Interfaces;
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NortwindAdmin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddDbContext<NorthWindContext>();

            services.AddScoped<ICustomer, CustomerRepository>();
            services.AddScoped<CustomerService>();

            services.AddScoped<IOrder, OrderRepository>();
            services.AddScoped<OrderService>();

            services.AddTransient<FormClientes>();

            var provider = services.BuildServiceProvider();

            var mainForm = provider.GetRequiredService<FormClientes>();
            Application.Run(mainForm);
        }
    }
}