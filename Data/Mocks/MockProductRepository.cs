using System;
using System.Collections.Generic;
using System.Linq;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                       Name = "Frito-Lay Doritos & Cheetos Mix Variety Pack, 40 Count",
                        Price = 11.99M,
                        InStock = true,
                        ImageUrl = "https://i5.walmartimages.com/asr/fa15f9d0-9e14-42ff-a192-5c58104520b6_1.27f886fb0aaace94f088904984cd566a.jpeg?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                        Category = _categoryRepository.Categories.First()
                    },
                    new Product
                    {
                        Name = "Frito-Lay Doritos & Cheetos Mix Variety Pack, 40 Count",
                        Price = 11.99M,
                        InStock = true,
                        ImageUrl = "https://i5.walmartimages.com/asr/fa15f9d0-9e14-42ff-a192-5c58104520b6_1.27f886fb0aaace94f088904984cd566a.jpeg?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                        Category = _categoryRepository.Categories.First()
                    },
                    new Product
                    {
                        Name = "Frito-Lay Doritos & Cheetos Mix Variety Pack, 40 Count",
                        Price = 11.99M,
                        InStock = true,
                        ImageUrl = "https://i5.walmartimages.com/asr/fa15f9d0-9e14-42ff-a192-5c58104520b6_1.27f886fb0aaace94f088904984cd566a.jpeg?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                        Category = _categoryRepository.Categories.First()
                    }
                };
            }

        }

        public IEnumerable<Nutrition> Nutritions { get; }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
