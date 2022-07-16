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
    //EfCoreProductRepository class EfCoreRpository tarafından imzası atılan methodları implement edildi
    //Eğer IRepository ve GenericRepository olmayan özel methodlar varsa EfCoreGenresRepository Interface yazıldığı için 
    //onuda implement ettik

    public class EfCoreProductRepository:GenericRepository<Urunler>,IProductDAL
    {
    }
}
