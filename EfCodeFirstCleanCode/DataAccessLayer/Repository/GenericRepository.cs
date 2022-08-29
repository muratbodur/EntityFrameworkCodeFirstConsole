using EfCodeFirstCleanCode.DataAccessLayer.Abstract;
using EfCodeFirstCleanCode.DataAccessLayer.Concrete;
using EfCodeFirstCleanCode.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstCleanCode.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();
        public void Delete(T t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public List<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }


        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();
        }

        
    }
}
