using System.Collections.Generic;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}