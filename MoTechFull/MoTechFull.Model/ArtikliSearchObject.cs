using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class ArtikliSearchObject
    {
        public string Naziv { get; set; }
        public int? KategorijaId { get; set; }
        public int? ProizvodjacId { get; set; }
        public bool? IncludeListKategorija { get; set; }
        public bool? IncludeListProizvodjac { get; set; }
    }
}
