using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class PersonelBolgeler
    {
        public int PersonelId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Personeller Personel { get; set; }
        public virtual Bolgeler Territory { get; set; }
    }
}
