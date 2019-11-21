using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Models
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }  
    }
}
