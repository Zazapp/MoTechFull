using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class KorpaArtikli
    {
        public int KorpaArtikliId { get; set; }
        public int KorpaId { get; set; }
        public int ArtikalId { get; set; }
        public int Kolicina { get; set; }


        public virtual Artikal Artikal { get; set; }
        public virtual Korpa Korpa { get; set; }
    }
}
