using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{ /// <summary>
  ///  databasedeki sutunlarımız modellendirildi
  /// </summary>

    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Descrition { get; set; }

        public List<Product> Products { get; set; }
    }
}
