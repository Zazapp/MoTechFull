using MoTechFull.Database;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Services
{
    public interface INarudzbeStavkeService: ICRUDService<Model.NarudzbeStavke, NarudzbeStavkeSearchObject, NarudzbeStavkeInsertRequest, object>
    {

    }
}
