using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Product> NewProducts { get; set; }
    }
}
