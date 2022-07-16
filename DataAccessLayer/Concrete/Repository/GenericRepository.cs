using DataAccessLayer.Abstract;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public List<T> GetAllList()
        {
            using (var c = new NorthwindContext())
            {
                return c.Set<T>().ToList();
            }
        }
        public T GetById(int id)
        {
            using (var c = new NorthwindContext())
            {
                return c.Set<T>().Find(id);
            }
        }
        public T GetSingle(T t)
        {
            using (var c = new NorthwindContext())
            {
                return c.Set<T>().SingleOrDefault();
            }
        }
    }
}
