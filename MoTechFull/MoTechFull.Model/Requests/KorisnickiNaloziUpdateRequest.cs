using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class KorisnickiNaloziUpdateRequest
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int Tip { get; set; }
    }
}
