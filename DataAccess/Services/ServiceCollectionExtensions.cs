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
            services.AddDbContext<NorthWindContext>(opt =>
                opt.UseSqlServer(config.GetConnectionString("NorthwindDatabase")));

            // Repositorios
            services.AddScoped<ICustomer, CustomerRepository>();
            services.AddScoped<IProduct, ProductRepository>();
            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<IReport, ReportRepository>();

            // Servicios
            services.AddScoped<CustomerService>();
            services.AddScoped<ProductService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<ReportService>();

            return services;
        }
    }
}