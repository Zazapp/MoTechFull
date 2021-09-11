using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class NarudzbeStavke
    {
        public int NarudzbaStavkeId { get; set; }
        public int ArtikalId { get; set; }
        public int KupacNarudzbeId { get; set; }
        public int RacunId { get; set; }
        public double UnitCijena { get; set; }
        public int Kolicina { get; set; }
        public float Popust { get; set; }

        public virtual Artikli Artikal { get; set; }
        public virtual KupciNarudzbe KupacNarudzbe { get; set; }
        public virtual Racuni Racun { get; set; }
    }
}
