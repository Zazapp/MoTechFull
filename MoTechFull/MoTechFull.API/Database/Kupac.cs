using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Kupac
    {
        public Kupac()
        {
            Korpas = new HashSet<Korpa>();
            KupacNarudzbes = new HashSet<KupacNarudzbe>();
            Recenzijas = new HashSet<Recenzija>();
        }

        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string EmailAdresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public int GradId { get; set; }
        public int? KorisnickiNalogId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        public virtual ICollection<Korpa> Korpas { get; set; }
        public virtual ICollection<KupacNarudzbe> KupacNarudzbes { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
    }
}
