using FitnessGym.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace FitnessGym.Infrastructure
{
    public class ProductSellerViewModel
    {
        public string s1 { get; set; }
        public string s2 { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public Dictionary<string, List<Product>> dictionary { get; set; } = new Dictionary<string, List<Product>>();

        public Dictionary<int, Category> dictionary2 { get; set; } = new Dictionary<int, Category>();
        public IEnumerable<SelectListItem> SelectListItems { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }



    }
}
