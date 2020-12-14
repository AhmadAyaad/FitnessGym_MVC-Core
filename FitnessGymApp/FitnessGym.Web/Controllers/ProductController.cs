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
    public class ProductController : Controller
    {
        private readonly IGetRepository<Category> _genericCategoryRepostiroy;
        private readonly IRepository<Product> _genericProductRepostiroy;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IGetRepository<Category> categoryRepostiroy,
                                    IRepository<Product> genericProductRepostiroy,
                                    IProductRepository productRepository,
                                    ICategoryRepository categoryRepository)
        {
            _genericCategoryRepostiroy = categoryRepostiroy;
            _genericProductRepostiroy = genericProductRepostiroy;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }




        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return View(await _genericProductRepostiroy.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categroies = await _genericCategoryRepostiroy.GetAll();
            ProductViewModel productViewModel = new ProductViewModel
            {
                Categories = categroies
            };
            return View(productViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel productViewModel)
        {
            Product product = new Product
            {
                ProductName = productViewModel.ProductName,
                Price = productViewModel.Price,
                CategoryId = productViewModel.CategoryId,
                Quantity = productViewModel.Quantity
            };

            try
            {
                await _genericProductRepostiroy.Create(product);
                ViewBag.SuccessMsg = "successfully added";

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }

            return View();
        }




        [HttpGet]
        public IActionResult SellProduct()
        {
            


                        var productSellerViewModel = _categoryRepository.GetCategoriesForProudctsInStock();
           
                        
            
            //productSellerViewModel.SelectListItems= new SelectList(productSellerViewModel.Products, "ProductId", "ProductName";
            return View(productSellerViewModel);
        }
    }
}
