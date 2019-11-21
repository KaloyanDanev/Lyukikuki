using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyukikuki.Data;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;
using Lyukikuki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lyukikuki.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ApplicationDbContext _context;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, ApplicationDbContext context)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _context = context;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(n => n.ProductId);
                currentCategory = "All products";
            }
            else
            {
                if (string.Equals("Food", _category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Food"))
                        .OrderBy(p => p.Name);
                }
                else

                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Drinks"))
                        .OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
            }
            else
            {
                products = _productRepository.Products.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Product/List.cshtml", new ProductListViewModel { Products = products, CurrentCategory = "All products" });
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Product());
            else
                return View(_context.Products.Find(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("ProductId,Name,Price,ImageUrl,InStock," +
        "ProductDetails,EnergyKj,EnergyKcal,Fat,Saturates,Carbohydrate," +
        "Sugars,Protein,Salt,CategoryId,Category")] Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductId == 0)
                    _context.Add(product);
                else
                    _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(product);
        }

        public ViewResult Details(int productId)
        {
            var product = _productRepository.Products.FirstOrDefault(d => d.ProductId == productId);
            if (product == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(product);
        }
    }
}