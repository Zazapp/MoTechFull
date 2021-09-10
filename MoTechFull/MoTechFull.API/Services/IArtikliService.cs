using MoTechFull.Database;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Services
{
    public interface IArtikliService: ICRUDService<Model.Artikli,Model.ArtikliSearchObject,ArtikliInsertRequest,ArtikliUpdateRequest>
    {
        List<Model.Artikli> Recommend(int id);
    }
}
