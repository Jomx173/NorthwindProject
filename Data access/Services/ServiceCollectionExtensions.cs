using DataAccess.Context;
using DataAccess.Repository;
using Domain.Models.Interfaces;
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<NorthWindContext>(opt => opt.UseSqlServer(config.GetConnectionString("NorthwindDatabase")));

            services.AddScoped<ICustomer, CustomerRepository>();

            services.AddScoped<ICustomer, CustomerRepository>();
            services.AddScoped<IReport, ReportRepository>();

            services.AddScoped<CustomerService>();
            services.AddScoped<ReportService>();

            return services;
        }
    }
}
