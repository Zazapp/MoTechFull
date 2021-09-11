using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Novosti
    {
        public int NovostiId { get; set; }
        public string Sadrzaj { get; set; }
        public int UposlenikId { get; set; }

    }
}
