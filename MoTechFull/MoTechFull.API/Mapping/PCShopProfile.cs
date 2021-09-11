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
            CreateMap<Database.Grad, Model.Gradovi>().ReverseMap();
            CreateMap<GradoviInsertUpdateRequest, Database.Grad>().ReverseMap();
            CreateMap<Database.Kanton, Model.Kantoni>().ReverseMap();
            CreateMap<KantoniInsertUpdateRequest, Database.Kanton>().ReverseMap();
            CreateMap<Database.Racun, Model.Racuni>().ReverseMap();
            CreateMap<RacuniInsertRequest, Database.Racun>().ReverseMap();
            CreateMap<Database.Korpa, Model.Korpe>().ReverseMap();
            CreateMap<KorpeInsertRequest, Database.Korpa>().ReverseMap();
            CreateMap<KorpeUpdateRequest, Database.Korpa>().ReverseMap();
            CreateMap<Database.KorpaArtikli, Model.KorpeArtikli>().ReverseMap();
            CreateMap<KorpeArtikliInsertRequest, Database.KorpaArtikli>().ReverseMap();
            CreateMap<KorpeArtikliUpdateRequest, Database.KorpaArtikli>().ReverseMap();
            CreateMap<Database.KupacNarudzbe, Model.KupciNarudzbe>().ReverseMap();
            CreateMap<KupciNarudzbeInsertRequest, Database.KupacNarudzbe>().ReverseMap();
        }
    }
}
