using Lyukikuki.Data.Models;
using System.Collections.Generic;
using Lyukikuki.Models;

namespace Lyukikuki.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}