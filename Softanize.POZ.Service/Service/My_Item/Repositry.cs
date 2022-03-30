using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Softanize.POZ.DataAccess.Models;

namespace Softanize.POZ.Service.Service.My_Item
{
    public class Repositry<T> : IRepositry<T> where T : Category
    {
        private readonly SoftanizeDevContext _context;
        private DbSet<T> entities;
        public Repositry(SoftanizeDevContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            try
            {
                return entities.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
