using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class ArtikalPonudum
    {
        public int ArtikalId { get; set; }
        public int PonudaId { get; set; }

        public virtual Artikal Artikal { get; set; }
        public virtual Ponudum Ponuda { get; set; }
    }
}
