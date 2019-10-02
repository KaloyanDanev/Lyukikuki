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
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = this.productRepository.GetProductById(6);

            var vm = new IndexViewModel
            {
                
            };

            return View(vm);
        }
    }
}
