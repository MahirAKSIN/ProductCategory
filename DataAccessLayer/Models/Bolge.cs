using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class Bolge
    {
        public Bolge()
        {
            Bolgelers = new HashSet<Bolgeler>();
        }

        public int BolgeId { get; set; }
        public string BolgeTanimi { get; set; }

        public virtual ICollection<Bolgeler> Bolgelers { get; set; }
    }
}
