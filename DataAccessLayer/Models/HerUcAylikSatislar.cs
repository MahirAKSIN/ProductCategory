using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class HerUcAylikSatislar
    {
        public string MusteriId { get; set; }
        public string SirketAdi { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
    }
}
