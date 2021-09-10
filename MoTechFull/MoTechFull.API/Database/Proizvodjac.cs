using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Proizvodjac
    {
        public Proizvodjac()
        {
            Artikals = new HashSet<Artikal>();
        }

        public int ProizvodjacId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Artikal> Artikals { get; set; }
    }
}
