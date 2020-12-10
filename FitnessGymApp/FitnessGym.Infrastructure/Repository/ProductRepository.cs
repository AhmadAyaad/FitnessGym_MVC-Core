using FitnessGym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public class ProductRepository : IRepository<Product>, IProductRepository
    {
        readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public async void Create(Product product)
        {
            if (product != null)
            {
                _context.Products.Add(product);
                var store = Store.GetStore;
                store.ProductId = product.ProductId;
                store.Product = product;
                _context.Stores.Add(store);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Product>> GetAll()
        {
            var products = await _context.Products.Where(p => p.Quantity > 0).ToListAsync();
            if (products != null)
                return products;
            return new List<Product>();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null) return product;
            return new Product();
        }

       
    }
}
