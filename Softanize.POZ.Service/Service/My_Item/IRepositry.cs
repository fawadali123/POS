using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softanize.POZ.DataAccess.Models;

namespace Softanize.POZ.Service.Service.My_Item
{
    public interface IRepositry<T> where T : Category
    {
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
