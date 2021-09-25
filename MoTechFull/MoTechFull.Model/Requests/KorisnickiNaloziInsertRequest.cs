using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class KorisnickiNaloziInsertRequest
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int Tip { get; set; }
    }
}
