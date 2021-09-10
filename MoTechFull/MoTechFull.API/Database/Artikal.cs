using System;
using System.Collections.Generic;
using MoTechFull.Database;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Artikal
    {
        public Artikal()
        {
            ArtikalPonuda = new HashSet<ArtikalPonudum>();
            DobavljacNarudzbaStavkes = new HashSet<DobavljacNarudzbaStavke>();
            KorpaArtiklis = new HashSet<KorpaArtikli>();
            NarudzbaStavkes = new HashSet<NarudzbaStavke>();
            Recenzijas = new HashSet<Recenzija>();
        }

        public int ArtikalId { get; set; }
        public string Naziv { get; set; }
        public int KategorijaId { get; set; }
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public byte[] Image { get; set; }
        public int ProizvodjacId { get; set; }
        public bool Dostupan { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
        public virtual ICollection<ArtikalPonudum> ArtikalPonuda { get; set; }
        public virtual ICollection<DobavljacNarudzbaStavke> DobavljacNarudzbaStavkes { get; set; }
        public virtual ICollection<KorpaArtikli> KorpaArtiklis { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
    }
}
