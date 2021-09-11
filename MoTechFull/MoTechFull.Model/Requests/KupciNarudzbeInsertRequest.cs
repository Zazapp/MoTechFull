using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class KupciNarudzbeInsertRequest
    {
        public int KorisnickiNalogId { get; set; }
        public string AdresaDostave { get; set; }
        public int GradId { get; set; }
        public DateTime Datum { get; set; }
        public bool IsIsporucena { get; set; }
    }
}
