using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class KorpeInsertRequest
    {
        public int KorisnickiNalogId { get; set; }
        public DateTime DatumDodavanja { get; set; }
    }
}
