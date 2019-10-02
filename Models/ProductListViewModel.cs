using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public string CurrentCategory { get; set; }
    }
}
