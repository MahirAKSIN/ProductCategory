using DataAccessLayer.Models;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Urunler>
    {
        //Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek
        //veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli
        //süreçlerden geçirip presentation katmanına gönderen katman
    }
}
