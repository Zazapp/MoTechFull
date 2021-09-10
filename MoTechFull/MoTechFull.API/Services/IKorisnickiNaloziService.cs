using MoTechFull.Database;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Services
{
    public interface IKorisnickiNaloziService
    {

        Task<Model.KorisnickiNalozi> Login(string username, string password);

        IList<Model.KorisnickiNalozi> Get(KorisnickiNaloziSearchObject search);

        Model.KorisnickiNalozi GetById(int id);

        Model.KorisnickiNalozi Insert(KorisnickiNaloziInsertUpdateRequest korisnici);

        Model.KorisnickiNalozi Update(int id, KorisnickiNaloziInsertUpdateRequest korisnici);
    }
}
