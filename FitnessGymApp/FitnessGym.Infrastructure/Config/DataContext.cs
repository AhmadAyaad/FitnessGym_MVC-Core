using FitnessGym.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FitnessGym.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
    }
}
