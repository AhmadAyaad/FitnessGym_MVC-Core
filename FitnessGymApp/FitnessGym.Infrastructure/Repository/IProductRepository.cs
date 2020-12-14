using FitnessGym.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetProduct(int id);
        List<Product> GetProductsInStock();
    }
}
