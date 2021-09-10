using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Recenzija
    {
        public int RecenzijaId { get; set; }
        public int Ocjena { get; set; }
        public string Sadrzaj { get; set; }
        public int ArtikalId { get; set; }
        public int KupacId { get; set; }

        public virtual Artikal Artikal { get; set; }
        public virtual Kupac Kupac { get; set; }
    }
}
