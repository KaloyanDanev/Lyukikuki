using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;
using Lyukikuki.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lyukikuki.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectProduct = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectProduct != null)
            {
                _shoppingCart.AddToCart(selectProduct, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectProduct = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectProduct);
            }
            return RedirectToAction("Index");
        }
    }
}