using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessGym.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public IEnumerable<Product> Products { get; set; } = new HashSet<Product>();

        public override string ToString()
        {
            return $"{CategoryName}";
        }
    }
}
