﻿using MoTechFull.Database;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Services
{
    public interface IKorpeArtikliService: ICRUDService<Model.KorpeArtikli, KorpeArtikliSearchObject, KorpeArtikliInsertRequest, KorpeArtikliUpdateRequest>
    {
        
    }
}
