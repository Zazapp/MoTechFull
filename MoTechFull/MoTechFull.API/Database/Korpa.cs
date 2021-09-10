using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Korpa
    {
        public Korpa()
        {
            KorpaArtiklis = new HashSet<KorpaArtikli>();
        }

        public int KorpaId { get; set; }
        public int KupacId { get; set; }
        public DateTime DatumDodavanja { get; set; }
        public string Opis { get; set; }

        public virtual Kupac Kupac { get; set; }
        public virtual ICollection<KorpaArtikli> KorpaArtiklis { get; set; }
    }
}
