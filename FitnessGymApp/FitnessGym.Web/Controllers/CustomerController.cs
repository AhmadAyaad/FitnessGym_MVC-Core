using FitnessGym.Infrastructure.Repository;
using FitnessGym.Models;
using FitnessGym.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessGym.Web.Controllers
{
    public class CustomerController : Controller
    {
        readonly IRepository<Customer> _customerRepository;
        private readonly IRepository<Coach> _coachRepository;

        public CustomerController(IRepository<Customer> customerRepository, IRepository<Coach> coachRepository)
        {
            _customerRepository = customerRepository;
            _coachRepository = coachRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _customerRepository.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var coachs = await _coachRepository.GetAll();
            CustomerViewModel customerViewModel = new CustomerViewModel()
            {
                Coaches = coachs
            };
            return View(customerViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerViewModel customerViewModel)
        {
                Customer customer = new Customer
                {
                    CustomerName = customerViewModel.CustomerName,
                    Age = customerViewModel.Age,
                    Phone = customerViewModel.Phone,
                    MemeberShipStartDate = customerViewModel.MemeberShipStartDate,
                    MemeberShipEndDate = customerViewModel.MemeberShipEndDate,
                    CoachId = customerViewModel.CoachId,
                    HealthStatus = customerViewModel.HealthStatus,
                    MemberShipType = customerViewModel.MemberShipType
                };
                try
                {
                    await _customerRepository.Create(customer);

                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {

                    Trace.WriteLine(e.Message);
                }
            return View();
        }
    }
}
