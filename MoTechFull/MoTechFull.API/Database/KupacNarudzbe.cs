using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class KupacNarudzbe
    {
        public KupacNarudzbe()
        {
            NarudzbaStavkes = new HashSet<NarudzbaStavke>();
        }

        public int KupacNarudzbeId { get; set; }
        public int KorisnickiNalogId { get; set; }
        public int AdresaId { get; set; }
        public string AdresaDostave { get; set; }
        public int GradId { get; set; }
        public DateTime Datum { get; set; }
        public bool IsIsporucena { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
    }
}
