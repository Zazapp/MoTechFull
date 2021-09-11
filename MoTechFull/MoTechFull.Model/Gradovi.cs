using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Model
{
    public class Gradovi
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int KantonId { get; set; }

        public virtual Kantoni Kanton { get; set; }
    }
}
