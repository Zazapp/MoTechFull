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
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class KorisnickiNalogController : ControllerBase
    {

        private readonly IKorisnickiNaloziService _service;

        public KorisnickiNalogController(IKorisnickiNaloziService service)
        {
            _service = service;
        }

        [HttpGet]
        public IList<Model.KorisnickiNalozi> Get([FromQuery] KorisnickiNaloziSearchObject request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.KorisnickiNalozi GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public Model.KorisnickiNalozi Insert(KorisnickiNaloziInsertUpdateRequest korisnici)
        {
            return _service.Insert(korisnici);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public Model.KorisnickiNalozi Update(int id, [FromBody] KorisnickiNaloziInsertUpdateRequest request)
        {
            return _service.Update(id, request);
        }

    }
}
