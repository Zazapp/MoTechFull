using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class ArtikliUpdateRequest
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public byte[] Image { get; set; }
        public int ProizvodjacId { get; set; }
        public int KategorijaId { get; set; }
    }
}
