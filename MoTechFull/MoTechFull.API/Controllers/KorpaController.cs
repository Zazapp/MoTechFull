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

    public class KorpaController : BaseCRUDController<Model.Korpe, KorpeSearchObject, KorpeInsertUpdateRequest, KorpeInsertUpdateRequest>
    {

        public KorpaController(IKorpeService service):base(service)
        {
        }

    }
}
