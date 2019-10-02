using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyukikuki.Data.Models
{
    public class Nutrition
    {
        public int NutritionId { get; set; }

        public double Energy { get; set; }

        public double Fat { get; set; }

        public double Saturates { get; set; }

        public double Carbohydrate { get; set; }

        public double Sugars { get; set; }

        public double Fibre { get; set; }

        public double Protein { get; set; }

        public double Salt { get; set; }
    }
}
