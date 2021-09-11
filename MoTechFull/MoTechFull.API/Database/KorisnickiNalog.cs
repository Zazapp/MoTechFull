using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class KorisnickiNalog
    {
        public KorisnickiNalog()
        {
            AutorizacijskiTokens = new HashSet<AutorizacijskiToken>();
            Kupacs = new HashSet<Kupac>();
        }

        public int KorisnickiNalogId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int Tip { get; set; }
        // 1=admin 2=prodavac 3=klijent

        public virtual ICollection<Korpa> Korpas { get; set; }
        public virtual ICollection<KupacNarudzbe> KupacNarudzbes { get; set; }
        public virtual ICollection<AutorizacijskiToken> AutorizacijskiTokens { get; set; }
        public virtual ICollection<Kupac> Kupacs { get; set; }
    }
}
