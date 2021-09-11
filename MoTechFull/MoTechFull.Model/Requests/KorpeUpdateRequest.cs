using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class KorpeUpdateRequest
    {
        public DateTime DatumDodavanja { get; set; }

        public int KorpeArtikliId { get; set; }
        public bool Dodaj { get; set; }
        //dodaj true=+, false=-
    }
}
