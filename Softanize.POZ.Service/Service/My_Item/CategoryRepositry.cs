using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Softanize.POZ.DataAccess.Models;
using Softanize.POZ.Model.DTO;

namespace Softanize.POZ.Service.Service.My_Item
{
    public class CategoryRepositry : CategoryInterface
    {
        private IRepositry<Category> _repositry;
        private readonly SoftanizeDevContext _context;
        private readonly IMapper _mapper;
        public CategoryRepositry(SoftanizeDevContext context, IMapper mapper, IRepositry<Category> repositry)
        {
            _context = context;
            _mapper = mapper;
            _repositry = repositry;
        }

        public void DeleteCategory(int Id)
        {
            Category category = _context.Category.FirstOrDefault(C => C.Id.Equals(Id));
            _repositry.Remove(category);
            _repositry.SaveChanges();
        }

        public List<Category> GetCategory()
        {
            var category= _context.Category.Where(c=>c.Name!=null).ToList();
            return category;
        }

        public void InsertCategory(Category category)
        {
            if (category.Id is 0) _repositry.Insert(category);
            else _repositry.Update(category);
        }

        public Category GetCategoryById(int Id)
        {
            var category = _context.Category.Where(c => c.Id == Id).FirstOrDefault();
            return category;
        }
    }
}
