using Data_access.Service;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace NorthwinAdmin
{
    internal static class Program
    {
       
       
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            using IHost host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddDataAccess(context.Configuration);

              
                services.AddTransient<CustomerServices>();
                services.AddTransient<EmployeesServices>();

                
                services.AddTransient<Form1>();
                services.AddTransient<FrmEmpleados>();

            }).Build();
            var mainForm = host.Services.GetRequiredService<FrmEmpleados>();
            Application.Run(mainForm);
        }
    }
}