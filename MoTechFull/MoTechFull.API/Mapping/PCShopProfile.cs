using AutoMapper;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Mapping
{
    public class PCShopProfile: Profile
    {
        public PCShopProfile() 
        {      
            CreateMap<Database.KorisnickiNalog, Model.KorisnickiNalozi>().ReverseMap();
            CreateMap<Database.Proizvodjac, Model.Proizvodjaci>().ReverseMap();
            CreateMap<Database.Kategorija, Model.Kategorije>().ReverseMap();
            CreateMap<Database.Artikal, Model.Artikli>().ReverseMap();
            CreateMap<KorisnickiNaloziInsertUpdateRequest, Database.KorisnickiNalog>().ReverseMap();
            CreateMap<KategorijeInsertUpdateRequest, Database.Kategorija>().ReverseMap();
            CreateMap<ProizvodjaciInsertUpdateRequest, Database.Proizvodjac>().ReverseMap();
            CreateMap<ArtikliInsertRequest, Database.Artikal>().ReverseMap();
            CreateMap<ArtikliUpdateRequest, Database.Artikal>().ReverseMap();
        }
    }
}
