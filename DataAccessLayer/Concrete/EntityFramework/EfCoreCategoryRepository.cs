using DataAccessLayer.Abstract;
using DataAccessLayer.Models;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
   public class EfCoreCategoryRepository:GenericRepository<Kategoriler>,ICategoryDAL
    {
    }
}
