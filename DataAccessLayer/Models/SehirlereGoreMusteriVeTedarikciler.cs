using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class SehirlereGoreMusteriVeTedarikciler
    {
        public string Sehir { get; set; }
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string Relationship { get; set; }
    }
}
