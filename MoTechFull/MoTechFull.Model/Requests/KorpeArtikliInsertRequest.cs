using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class KorpeArtikliInsertRequest
    {
        public int KorpaId { get; set; }
        public int ArtikalId { get; set; }
        public int Kolicina { get; set; }
    }
}
