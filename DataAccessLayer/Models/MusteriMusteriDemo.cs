using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class MusteriMusteriDemo
    {
        public string MusteriId { get; set; }
        public string MusteriTypeId { get; set; }

        public virtual Musteriler Musteri { get; set; }
        public virtual MusteriDemographic MusteriType { get; set; }
    }
}
