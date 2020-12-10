using FitnessGym.Infrastructure.Repository;
using FitnessGym.Models;
using FitnessGym.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessGym.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Customer> _customerRepository;

        public HomeController(ILogger<HomeController> logger, IRepository<Customer> customerRepository)
        {
            _logger = logger;
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            Trace.WriteLine(await _customerRepository.GetAll());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
