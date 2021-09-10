using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class KategorijeInsertUpdateRequest
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Image { get; set; }
    }
}
