using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class MusteriDemographic
    {
        public MusteriDemographic()
        {
            MusteriMusteriDemos = new HashSet<MusteriMusteriDemo>();
        }

        public string MusteriTypeId { get; set; }
        public string MusteriDesc { get; set; }

        public virtual ICollection<MusteriMusteriDemo> MusteriMusteriDemos { get; set; }
    }
}
