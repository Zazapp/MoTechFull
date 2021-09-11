using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class Korpe
    {
        public int KorpaId { get; set; }
        public int KorisnickiNalogId { get; set; }
        public DateTime DatumDodavanja { get; set; }

        public virtual KorisnickiNalozi KorisnickiNalog { get; set; }
    }
}
