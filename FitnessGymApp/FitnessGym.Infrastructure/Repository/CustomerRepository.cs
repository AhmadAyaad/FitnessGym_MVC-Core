using FitnessGym.Infrastructure.Helpers;
using FitnessGym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        readonly DataContext _context;
        private readonly Helper _helper;

        public CustomerRepository(DataContext context, Helper helper)
        {
            _context = context;
            _helper = helper;
        }

        public async void Create(Customer customer)
        {
            if (customer != null)
            {
                if (!_helper.CheckIfCustomerExists(customer))
                    _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
            }
        }


        public async Task<List<Customer>> GetAll()
        {

            //var customers =  from s in _context.Customers select s;

            var customers = await _context.Customers.ToListAsync();
            if (customers != null)
                return customers;

            return new List<Customer>();
        }


    }
}
