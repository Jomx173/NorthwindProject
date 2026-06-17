using Data_access.Context;
using Data_access.Repository.CustomerRepository;
using Domain.Models.Intefaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_access.Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<NorthWindContext>(opt => opt.UseSqlServer(config.GetConnectionString("NorthwindDatabase")));
            services.AddScoped<ICustomer, CustomerRepository>();

            
            services.AddScoped<IEmployees, DataAccess.Repository.EmployeeRepository.EmployeeRepository>();

            return services;
        }

    }
}
