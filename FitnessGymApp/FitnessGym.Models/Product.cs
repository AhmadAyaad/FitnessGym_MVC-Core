using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessGym.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 0;

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public override string ToString()
        {
            return $"{ProductName}";
        }
    }
}
