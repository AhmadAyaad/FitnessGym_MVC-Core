using FitnessGym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public class CategoryRepository : IGetRepository<Category>, IGetByNameRepository<Category>
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
    }
}
