using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class DobavljacNarudzba
    {
        public DobavljacNarudzba()
        {
            DobavljacNarudzbaStavkes = new HashSet<DobavljacNarudzbaStavke>();
        }

        public int DobavljacNarudzbaId { get; set; }
        public int DobavljacId { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public bool IsIsporucena { get; set; }

        public virtual Dobavljac Dobavljac { get; set; }
        public virtual ICollection<DobavljacNarudzbaStavke> DobavljacNarudzbaStavkes { get; set; }
    }
}
