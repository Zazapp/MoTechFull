﻿using MoTechFull.Database;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Services
{
    public interface IRacuniService : ICRUDService<Model.Racuni, RacuniSearchObject, RacuniInsertRequest, RacuniUpdateRequest>
    {

    }
}
