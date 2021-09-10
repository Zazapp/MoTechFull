using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Ponudum
    {
        public Ponudum()
        {
            ArtikalPonuda = new HashSet<ArtikalPonudum>();
        }

        public int PonudaId { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<ArtikalPonudum> ArtikalPonuda { get; set; }
    }
}
