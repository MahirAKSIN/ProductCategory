using DataAccessLayer.Abstract;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    //GenericRepository classı IRepositorydeki bos olusturulan methodları imzasını atıldı.
    //temel sınıf kısıtlaması, derleyiciye yalnızca bu türden veya bu türden türetilen nesnelerin tür bağımsız değişkenleri olarak kullanılacağını söyler
    //bunun için 'where TEntity : class' kullandık


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
