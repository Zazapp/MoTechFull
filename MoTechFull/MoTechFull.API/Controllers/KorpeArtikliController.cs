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

    public class KorpeArtikliController : BaseCRUDController<Model.KorpeArtikli, KorpeArtikliSearchObject, KorpeArtikliInsertRequest, KorpeArtikliUpdateRequest>
    {

        public KorpeArtikliController(IKorpeArtikliService service):base(service)
        {
        }

    }
}
