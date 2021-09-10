using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Uposlenik
    {
        public Uposlenik()
        {
            Novostis = new HashSet<Novosti>();
            Racuns = new HashSet<Racun>();
        }

        public int UposlenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public double IznosPlate { get; set; }
        public string Adresa { get; set; }
        public int? GradId { get; set; }
        public int? KorisnickiNalogId { get; set; }
        public bool IsAktivan { get; set; }
        public string Email { get; set; }
        public string Jmbg { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        public virtual ICollection<Novosti> Novostis { get; set; }
        public virtual ICollection<Racun> Racuns { get; set; }
    }
}
