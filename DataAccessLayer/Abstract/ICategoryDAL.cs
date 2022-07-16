using DataAccessLayer.Models;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    /// <summary>
    /// Bu interfacede  ICategoryDAL özel methodlar yazılabilir.
    /// Diğer methodlar solid kurallarını göz önüne alarak IRepository imzasız bir şekilde yazıldı.
    /// Imzasız methodlar GenericRepositoryde imzalanacaktır
    /// </summary>


    public interface ICategoryDAL:IRepository<Kategoriler>
    {
    }
}
