using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Lyukikuki.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Lyukikuki.Models;

namespace Lyukikuki.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                NewProducts = _productRepository.Products.OrderByDescending(x=>x.ProductId).Take(12)
            };
            return View(homeViewModel);
        
        }
    }
}
