using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class KorpeSearchObject
    {
        public int? KorpaId { get; set; }
        public int? KorisnickiNalogId { get; set; }

        public bool? IncludeListKorisnickiNalog { get; set; }
    }
}
