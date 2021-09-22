using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class RacuniInsertRequest
    {
        public int KorisnickiNalogId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public double Iznos { get; set; }
    }
}
