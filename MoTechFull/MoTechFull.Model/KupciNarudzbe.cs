using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class KupciNarudzbe
    {
        public int KupacNarudzbeId { get; set; }
        public int KorisnickiNalogId { get; set; }
        public string AdresaDostave { get; set; }
        public int GradId { get; set; }
        public DateTime Datum { get; set; }
        public bool IsIsporucena { get; set; }

        public virtual Gradovi Grad { get; set; }
        public virtual KorisnickiNalozi KorisnickiNalog { get; set; }
    }
}
