using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class KorpeArtikliSearchObject
    {
        public int? KorpaArtikliId { get; set; }
        public int? KorpaId { get; set; }
        public int? ArtikalId { get; set; }

        public bool? IncludeListKorpa { get; set; }
        public bool? IncludeListArtikal { get; set; }
    }
}
