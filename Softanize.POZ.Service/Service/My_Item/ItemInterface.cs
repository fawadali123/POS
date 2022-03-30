using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softanize.POZ.DataAccess.Models;
namespace Softanize.POZ.Service.Service.My_Item
{
    public interface ItemInterface
    {
        List<Item> GetCategory();
        void InsertCategory(Item item,long subCategoryId);
        void DeleteCategory(int Id);
    }
}
