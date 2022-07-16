using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class Musteriler
    {
        public Musteriler()
        {
            MusteriMusteriDemos = new HashSet<MusteriMusteriDemo>();
            Satislars = new HashSet<Satislar>();
        }

        public string MusteriId { get; set; }
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriUnvani { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }

        public virtual ICollection<MusteriMusteriDemo> MusteriMusteriDemos { get; set; }
        public virtual ICollection<Satislar> Satislars { get; set; }
    }
}
