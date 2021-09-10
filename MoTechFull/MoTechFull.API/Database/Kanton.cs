using System;
using System.Collections.Generic;

#nullable disable

namespace MoTechFull.Database
{
    public partial class Kanton
    {
        public Kanton()
        {
            Grads = new HashSet<Grad>();
        }

        public int KantonId { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public virtual ICollection<Grad> Grads { get; set; }
    }
}
