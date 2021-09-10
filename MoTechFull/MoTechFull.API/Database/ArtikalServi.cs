using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class ArtikalServi
    {
        public int ArtikalServisId { get; set; }
        public int NarudzbaStavkeId { get; set; }
        public string ServiserNaziv { get; set; }
        public DateTime DatumPrijema { get; set; }
        public DateTime DatumZavrsetka { get; set; }

        public virtual NarudzbaStavke NarudzbaStavke { get; set; }
    }
}
