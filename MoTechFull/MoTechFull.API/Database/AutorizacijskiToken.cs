using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class AutorizacijskiToken
    {
        public int Id { get; set; }
        public string Vrijednost { get; set; }
        public int KorisnickiNalogId { get; set; }
        public DateTime VrijemeEvidentiranja { get; set; }
        public string IpAdresa { get; set; }

        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
    }
}
