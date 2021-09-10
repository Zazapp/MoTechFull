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

    public class KategorijaController : BaseCRUDController<Model.Kategorije, KategorijeSearchObject, KategorijeInsertUpdateRequest,KategorijeInsertUpdateRequest>
    {

        public KategorijaController(IKategorijeService service):base(service)
        {
        }

    }
}
