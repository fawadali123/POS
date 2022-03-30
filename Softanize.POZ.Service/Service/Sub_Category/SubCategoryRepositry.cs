using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Softanize.POZ.DataAccess.Models;

namespace Softanize.POZ.Service.Service.Sub_Category
{
    public class SubCategoryRepositry : SubCategoryInterfase
    {
        private readonly SoftanizeDevContext _context;
        public SubCategoryRepositry(SoftanizeDevContext context)
        {
            _context = context;
        }
        public void DeleteSubCategory(int Id)
        {
            SubCategory category = _context.SubCategory.FirstOrDefault(C => C.Id.Equals(Id));
            _context.Remove(category);
            _context.SaveChanges();
        }

        public void DeleteSubCategoryByCategoryId(int Id)
        {
            var subcategory = _context.SubCategory.Where(c=>c.CategoryId==Id).FirstOrDefault();
            _context.SubCategory.Remove(subcategory);
            _context.SaveChanges();

        }

        public List<SubCategory> GetSubCategory()
        {
            return _context.SubCategory.ToList();
        }

        public void InsertSubCategory(SubCategory category,long CategoryId)
        {
            if (category.Id is 0)
            {
                category.CategoryId = CategoryId;
                _context.Add(category);
            }
            else {
                category.CategoryId = CategoryId;
                _context.Update(category);
            } 
            _context.SaveChanges();
        }
    }
}
