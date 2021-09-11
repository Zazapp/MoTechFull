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

    public class KantonController : BaseCRUDController<Model.Kantoni, KantoniSearchObject, KantoniInsertUpdateRequest, KantoniInsertUpdateRequest>
    {

        public KantonController(IKantoniService service):base(service)
        {
        }

    }
}
