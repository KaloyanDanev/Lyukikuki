using System.Collections.Generic;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository

    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Food"},
                    new Category{CategoryName = "Drinks"}
                };
            }
        }
    }
}
