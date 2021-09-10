using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Dobavljac
    {
        public Dobavljac()
        {
            DobavljacNarudzbas = new HashSet<DobavljacNarudzba>();
        }

        public int DobavljacId { get; set; }
        public string Naziv { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<DobavljacNarudzba> DobavljacNarudzbas { get; set; }
    }
}
