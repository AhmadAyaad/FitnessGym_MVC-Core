using FitnessGym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessGym.Web.ViewModel
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 0;
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
