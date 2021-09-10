using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class NarudzbaStavke
    {
        public NarudzbaStavke()
        {
            ArtikalServis = new HashSet<ArtikalServi>();
        }

        public int NarudzbaStavkeId { get; set; }
        public int ArtikalId { get; set; }
        public int KupacNarudzbeId { get; set; }
        public int RacunId { get; set; }
        public double UnitCijena { get; set; }
        public int Kolicina { get; set; }
        public float Popust { get; set; }

        public virtual Artikal Artikal { get; set; }
        public virtual KupacNarudzbe KupacNarudzbe { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual ICollection<ArtikalServi> ArtikalServis { get; set; }
    }
}
