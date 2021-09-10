using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class DobavljacNarudzbaStavke
    {
        public int DobavljacNarudzbaStavkeId { get; set; }
        public int ArtikalId { get; set; }
        public int DobavljacNarudzbaId { get; set; }
        public double Cijena { get; set; }
        public int Kolicina { get; set; }

        public virtual Artikal Artikal { get; set; }
        public virtual DobavljacNarudzba DobavljacNarudzba { get; set; }
    }
}
