using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softanize.POZ.DataAccess.Models;

namespace Softanize.POZ.Service.Service.My_Item
{
    public class ItemRepositry : ItemInterface
    {
        private readonly SoftanizeDevContext _context;
        public ItemRepositry(SoftanizeDevContext context)
        {
            _context = context;;
        }
        public void DeleteCategory(int Id)
        {
            Item item = _context.Item.FirstOrDefault(C => C.Id.Equals(Id));
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<Item> GetCategory()
        {
            return _context.Item.ToList();
        }

        public void InsertCategory(Item item, long subCategoryId)
        {
            if (item.Id is 0)
            {
                item.SubCategoryId = subCategoryId;
                _context.Add(item);
            }
            else {
                item.SubCategoryId = subCategoryId;
                _context.Update(item);
            } 
            _context.SaveChanges();
        }
    }
}
