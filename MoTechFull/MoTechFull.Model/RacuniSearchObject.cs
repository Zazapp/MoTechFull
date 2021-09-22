using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class RacuniSearchObject
    {
        public int RacunId { get; set; }
        public int? KorisnickiNalogId { get; set; }
        public double? Iznos { get; set; }
        public DateTime? DatumIzdavanja { get; set; }

    }
}
