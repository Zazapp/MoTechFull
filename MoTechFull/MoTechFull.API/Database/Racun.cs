using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Racun
    {
        public Racun()
        {
            NarudzbaStavkes = new HashSet<NarudzbaStavke>();
        }

        public int RacunId { get; set; }
        public int UposlenikId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public double Iznos { get; set; }

        public virtual Uposlenik Uposlenik { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
    }
}
