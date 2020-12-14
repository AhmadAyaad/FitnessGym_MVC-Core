using FitnessGym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public class CategoryRepository : IGetRepository<Category>, IGetByNameRepository<Category>
                                    , ICategoryRepository
    {
        readonly DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<List<Category>> GetAll()
        {
            var categories = await _context.Categories.ToListAsync();
            if (categories != null)
                return categories;
            return new List<Category>();
        }

        public async Task<Category> GetByName(string name)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(c => c.CategoryName == name);

            if (category != null)
                return category;
            return new Category();

        }

        public List<ProductSellerViewModel> GetCategoriesForProudctsInStock()
        {

           var j =  from s in _context.Products.ToList()// outer sequence
            join st in _context.Categories.ToList() //inner sequence 
            on s. ProductId equals st.CategoryId// key selector 
            select new ProductSellerViewModel
            { // result selector 
                s1 = s.ProductName,
                s2 = st.CategoryName,
                ProductId = s.ProductId ,
                 CategoryId= st.CategoryId
            };


            var c=  _context.Categories.Include(c=>c.Products).AsNoTracking().ToList().Distinct();
           var p =  c.SelectMany(c => c.Products).ToList();
            Dictionary<string, List<Product>> dictionary = new Dictionary<string, List<Product>>();
            Dictionary<int, Category> dictionary2 = new Dictionary<int, Category>();

            //foreach (var item in c)
            //{
            //    dictionary2.Add(item.CategoryId, item.);
            //}
          

            ProductSellerViewModel productSellerViewModel = new ProductSellerViewModel();
            productSellerViewModel.Products = p.Where(p=>p.Quantity>0).ToList();
            productSellerViewModel.Categories = c.ToList();
            productSellerViewModel.dictionary = dictionary;
            productSellerViewModel.dictionary2 = dictionary2;
            

            return j.ToList();
        }
    }
}
