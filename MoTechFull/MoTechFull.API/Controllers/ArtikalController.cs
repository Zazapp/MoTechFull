using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoTechFull.Database;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using MoTechFull.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Controllers
{

    public class ArtikalController : BaseCRUDController<Model.Artikli, Model.ArtikliSearchObject,ArtikliInsertRequest, ArtikliUpdateRequest>
    {

        public ArtikalController(IArtikliService service) : base(service)
        {
        }

        [AllowAnonymous]
        [HttpGet("Recommend/{id}")]
        public List<Model.Artikli> Recommend(int id) 
        {
            return (_service as IArtikliService).Recommend(id);
        }
    }
}
