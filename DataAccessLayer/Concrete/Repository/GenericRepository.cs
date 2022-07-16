using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class GenericRepository<T> : IRepository<T> where T: class
    {
        public List<T> GetAllList()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(T t)
        {
            throw new NotImplementedException();
        }
    }
}
