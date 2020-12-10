using FitnessGym.Infrastructure.Repository;
using FitnessGym.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessGym.Infrastructure.Config
{
    public class Configure
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Customer>, CustomerRepository>();
            services.AddScoped<IRepository<Coach>, CoachRepository>();
            services.AddScoped<IGetByNameRepository<Coach>, CoachRepository>();

        }
    }
}
