﻿using System;
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
            Uposleniks = new HashSet<Uposlenik>();
        }

        public int KorisnickiNalogId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int Tip { get; set; }
        // 1=admin 2=prodavac 3=klijent

        public virtual ICollection<AutorizacijskiToken> AutorizacijskiTokens { get; set; }
        public virtual ICollection<Kupac> Kupacs { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}
