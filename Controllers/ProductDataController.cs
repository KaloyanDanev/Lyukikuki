using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;
using Lyukikuki.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lyukikuki.Controllers
{
    [Route("api/[controller]")]
    public class ProductDataController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductDataController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }



        [HttpGet]
        public IEnumerable<ProductViewModel> LoadMoreProducts()
        {
            IEnumerable<Product> dbProducts = null;

            dbProducts = _productRepository.Products.OrderBy(p => p.ProductId).Take(10);

            List<ProductViewModel> products = new List<ProductViewModel>();

            foreach (var dbProduct in dbProducts)
            {
                products.Add(MapDbProductToProductViewModel(dbProduct));
            }
            return products;
        }

        private ProductViewModel MapDbProductToProductViewModel(Product dbProduct) => new ProductViewModel()
        {
            ProductId = dbProduct.ProductId,
            Name = dbProduct.Name,
            Price = dbProduct.Price,
            ImageUrl = dbProduct.ImageUrl,
           
        };

    }
}