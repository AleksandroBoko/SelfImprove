using SelfImprovment.Core.Categories.DTO;
using System.Collections.Generic;

namespace SelfImprovment.Core.Categories.Interfaces
{
    public interface ICategoriesRepository
    {
        CategoryDto GetCategoryById(int id);
        IEnumerable<CategoryDto> GetCategories();
    }
}
