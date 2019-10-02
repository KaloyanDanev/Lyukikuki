using System.Collections.Generic;
using System.Linq;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;
using Lyukikuki.Models;
using Microsoft.EntityFrameworkCore;

namespace Lyukikuki.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Product> Products => _applicationDbContext.Products.Include(c => c.Category);
        public IEnumerable<Nutrition> Nutritions { get; }

        public Product GetProductById(int productId) =>
            _applicationDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
    }
}