using System.Collections.Generic;

using Domain;

namespace BLL.Interfaces
{
    public interface IServiceCategory
    {
        List<Category> GetAllCategory();
        Category GetCategory(int id);
        Category GetCategory(string name);
    }
}
