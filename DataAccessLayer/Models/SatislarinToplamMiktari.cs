using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class SatislarinToplamMiktari
    {
        public decimal? SaleAmount { get; set; }
        public int SatisId { get; set; }
        public string SirketAdi { get; set; }
        public DateTime? SevkTarihi { get; set; }
    }
}
