using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoTechFull.Model.Requests
{
    public class GradoviInsertUpdateRequest
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Naziv { get; set; }
        public int KantonId { get; set; }
    }
}
