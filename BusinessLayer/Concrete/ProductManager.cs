using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    /// <summary>
    /// Bu classta IProductService'i implement yaparak imzasız olana 
    /// methodları içine linq sorguları ile imzalanır. 
    /// 
    /// </summary>

    public class ProductManager : IProductService
    {

        EfCoreProductRepository efCoreProduct;

        public ProductManager(EfCoreProductRepository efCoreProduct)
        {
            this.efCoreProduct = efCoreProduct;
        }

        public List<Urunler> GetList()
        {
            return efCoreProduct.GetAllList();
        }

        public Urunler GetSingle(Urunler t)
        {
            return efCoreProduct.GetSingle(t);
        }

        public Urunler TGetById(int id)
        {
            return efCoreProduct.GetById(id);
                }
    }
}
