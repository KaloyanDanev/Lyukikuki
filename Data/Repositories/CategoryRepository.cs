using System.Collections.Generic;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Category> Categories => _applicationDbContext.Categories;
    }
}