using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public  interface IServiceCategory
    {
        List<Category> GetAllCategory();
        Category GetCategory(int id);

    }
}
