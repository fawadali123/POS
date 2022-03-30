using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softanize.POZ.DataAccess.Models;

namespace Softanize.POZ.Service.Service.Sub_Category
{
    public interface SubCategoryInterfase
    {
        List<SubCategory> GetSubCategory();
        void InsertSubCategory(SubCategory category, long CategoryId);
        void DeleteSubCategory(int Id);
        void DeleteSubCategoryByCategoryId(int Id);
    }
}
