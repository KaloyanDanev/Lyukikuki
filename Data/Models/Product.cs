using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyukikuki.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int NutritionId { get; set; }

        public virtual Nutrition Nutrition { get; set; }
    }
}
