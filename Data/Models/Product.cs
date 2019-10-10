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

        public string ProductDetails { get; set; }

        //Nutrition

        public double EnergyKj { get; set; }

        public double EnergyKcal { get; set; }

        public double Fat { get; set; }

        public double Saturates { get; set; }

        public double Carbohydrate { get; set; }

        public double Sugars { get; set; }

        public double Protein { get; set; }

        public double Salt { get; set; }

        //

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
