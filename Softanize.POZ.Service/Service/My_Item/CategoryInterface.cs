using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softanize.POZ.DataAccess.Models;
using Softanize.POZ.Model.DTO;

namespace Softanize.POZ.Service.Service.My_Item
{
    public interface CategoryInterface
    {
        List<Category> GetCategory();
        Category GetCategoryById(int Id);
        void InsertCategory(Category category);
        void DeleteCategory(int Id);

    }
}
