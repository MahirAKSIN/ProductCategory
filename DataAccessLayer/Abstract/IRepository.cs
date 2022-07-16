using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{

    //database crud işlemleri ve ekstra methodların olusturuşduğu Interface
    //ilişkilerin başladığı class
    //Genericrepository De bu boş  methodların imzası atılacaktır

    public interface IRepository<T>
    {
        List<T> GetAllList();
        T GetById(int id);
        T GetSingle(T t);
    }
}
