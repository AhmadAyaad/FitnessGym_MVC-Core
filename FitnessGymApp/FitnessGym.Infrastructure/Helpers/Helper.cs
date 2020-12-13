using FitnessGym.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessGym.Infrastructure.Helpers
{
    public class Helper
    {
        readonly DataContext _context;

        public Helper(DataContext context)
        {
            _context = context;
        }
        public bool CheckIfCustomerExists(Customer customer)
        {
            return _context.Customers.Any(c => c.Phone == customer.Phone);
        }
    }
}
