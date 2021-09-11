﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class KorpeArtikli
    {
        public int KorpaArtikliId { get; set; }
        public int KorpaId { get; set; }
        public int ArtikalId { get; set; }
        public int Kolicina { get; set; }

        public virtual Artikli Artikal { get; set; }
        public virtual Korpe Korpa { get; set; }
    }
}
