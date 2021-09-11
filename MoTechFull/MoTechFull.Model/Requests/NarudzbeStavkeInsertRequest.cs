using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class NarudzbeStavkeInsertRequest
    {
        public int ArtikalId { get; set; }
        public int KupacNarudzbeId { get; set; }
        public int RacunId { get; set; }
        public double UnitCijena { get; set; }
        public int Kolicina { get; set; }
        public float Popust { get; set; }
    }
}
