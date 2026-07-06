using Data_access.Service;
using DataAccess.Repository.EmployeeRepository;
using Domain.Models.Intefaces;
using Domain.Services;
using Data_access.Repository;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using IHost host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddDataAccess(context.Configuration);

                // 1. Registramos la interfaz con su repositorio real (visto en la capa DataAccess)
                services.AddTransient<IEmployees, EmployeeRepository>();

            
                services.AddTransient<CustomerServices>();
                services.AddTransient<EmployeesServices>();

                
                services.AddTransient<FrmEmpleados>();

            }).Build();
       
            host.Start();
            Application.Run(host.Services.GetRequiredService<FrmEmpleados>());
        }
    }
}