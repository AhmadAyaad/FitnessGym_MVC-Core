using FitnessGym.Infrastructure.Repository;
using FitnessGym.Web.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessGym.Web.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ApiProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ApiProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductQuantity(int id)
        {
            var product = await _productRepository.GetProduct(id);
            return Ok(product);
        }


        //[HttpPost]
        //public IActionResult SellProduct(Test test)
        //{

        //    return StatusCode(201);
        //}
    }
}
