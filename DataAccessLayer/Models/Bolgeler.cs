using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class Bolgeler
    {
        public Bolgeler()
        {
            PersonelBolgelers = new HashSet<PersonelBolgeler>();
        }

        public string TerritoryId { get; set; }
        public string TerritoryTanimi { get; set; }
        public int BolgeId { get; set; }

        public virtual Bolge Bolge { get; set; }
        public virtual ICollection<PersonelBolgeler> PersonelBolgelers { get; set; }
    }
}
