using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Dobavljacs = new HashSet<Dobavljac>();
            KupacNarudzbes = new HashSet<KupacNarudzbe>();
            Kupacs = new HashSet<Kupac>();
        }

        public int GradId { get; set; }
        public int KantonId { get; set; }
        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }

        public virtual Kanton Kanton { get; set; }
        public virtual ICollection<Dobavljac> Dobavljacs { get; set; }
        public virtual ICollection<KupacNarudzbe> KupacNarudzbes { get; set; }
        public virtual ICollection<Kupac> Kupacs { get; set; }
    }
}
