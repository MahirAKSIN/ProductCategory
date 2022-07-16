using BusinessLayer.Abstract;
using DataAccessLayer.Models;
using DataAccessLayer.Concrete.EntityFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    /// <summary>
    /// Bu classta ICategoryService'i implement yaparak imzasız olana 
    /// methodları içine linq sorguları ile imzalanır. 
    /// 
    /// </summary>

    public class CategoryManager : ICategoryService
    {


        EfCoreCategoryRepository efCoreCategory;

        public CategoryManager(EfCoreCategoryRepository efCoreCategory)
        {
            this.efCoreCategory = efCoreCategory;
        }

        public List<Kategoriler> GetList()
        {
            return efCoreCategory.GetAllList();
        }

        public Kategoriler GetSingle(Kategoriler t)
        {
            return efCoreCategory.GetSingle(t);
        }

        public Kategoriler TGetById(int id)
        {
            return efCoreCategory.GetById(id);
        }
    }
}
