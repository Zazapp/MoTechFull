using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Artikals = new HashSet<Artikal>();
        }

        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Artikal> Artikals { get; set; }
    }
}
