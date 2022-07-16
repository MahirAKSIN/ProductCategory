using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class KategorilereGoreSatislar
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Urunlerales { get; set; }
    }
}
