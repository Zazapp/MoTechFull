using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class Artikli
    {
        public int ArtikalId { get; set; }
        public string Naziv { get; set; }
        public int KategorijaId { get; set; }
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public byte[] Image { get; set; }
        public int ProizvodjacId { get; set; }
        public bool Dostupan { get; set; }

        public virtual Kategorije Kategorija { get; set; }
        public virtual Proizvodjaci Proizvodjac { get; set; }


        public string KategorijaIdNaziv => $"{Kategorija?.KategorijaId} - {Kategorija?.Naziv}";
        public string ProizvodjacIdNaziv => $"{Proizvodjac?.ProizvodjacId} - {Proizvodjac?.Naziv}";
    }
}
