using FitnessGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public class StoreRepository
    {
        readonly DataContext _context;
        IProductRepository _productRepository;
        public StoreRepository(DataContext context , IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository ;
        }

        public async Task<List<Product>> GetProducts()
        {
            var stores = _context.Stores.ToList();
            var products = new List<Product>();
            foreach (var item in stores)
            {
                var product = await _productRepository.GetProduct((int)item.ProductId);
                if (product.ProductName != null)
                    products.Add(product);
            }
            return products;
        }
    }
}
