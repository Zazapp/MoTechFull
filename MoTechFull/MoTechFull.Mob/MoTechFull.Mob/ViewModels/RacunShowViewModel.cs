using MoTechFull.Mob.Services;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class RacunShowViewModel:BaseViewModel
    {
        private readonly APIService _korpeService = new APIService("Korpa");
        private readonly APIService _korisniciService = new APIService("KorisnickiNalog");
        private readonly APIService _korpeArtikliService = new APIService("KorpeArtikli");
        private readonly APIService _racuniService = new APIService("Racun");
        private readonly APIService _kupciNarudzbeService = new APIService("KupacNarudzbe");
        private readonly APIService _narudzbeStavkeService = new APIService("NarudzbaStavke");

        public Gradovi ggrad;
        public string aadresa;
        public RacunShowViewModel() 
        {
            ggrad = APIService.Grad;
            aadresa = APIService.Adresa;
            PrikaziRacunC = new Command(PrikaziRacun);
            InitCommand = new Command(Init);
            Ok = new Command(PerformOk);
        }

        public ObservableCollection<NarudzbeStavke> narudzbaStavke { get; set; } = new ObservableCollection<NarudzbeStavke>();

        bool racun = false;
        int korisnikId = 0;
        int korpaId = 0;
        double _ukupno = 0;

        public double Ukupno 
        {

            get { return _ukupno; }
            set
            {
                SetProperty(ref _ukupno, value);
                
                    InitCommand.Execute(null);
                

            }
        }
        public Gradovi Grad
        {
            get { return ggrad; }
            set
            {
                SetProperty(ref ggrad, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
        public string Adress
        {
            get { return aadresa; }
            set
            {
                SetProperty(ref aadresa, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
        public Command InitCommand { get; }
        public Command PrikaziRacunC { get; }

        public Command Ok { get; }

        public void Init() { return; }
        public async void PrikaziRacun()
        {
            var listKorisnika = await _korisniciService.Get<List<Model.KorisnickiNalozi>>();
            korisnikId = listKorisnika.Where(q => q.KorisnickoIme == APIService.Username && q.Lozinka == APIService.Password).Select(w => w.KorisnickiNalogId).FirstOrDefault();

            KorpeSearchObject korpeS = new KorpeSearchObject()
            {
                KorisnickiNalogId = korisnikId
            };

            var listaKorpi = await _korpeService.Get<List<Korpe>>(korpeS);

            korpaId = listaKorpi.Last().KorpaId;

            var listaKorpaArtikli = await _korpeArtikliService.Get<List<Model.KorpeArtikli>>
                (new KorpeArtikliSearchObject() { IncludeListArtikal = true, IncludeListKorpa = true, KorpaId = korpaId });

            RacuniInsertRequest racunIR = new RacuniInsertRequest { DatumIzdavanja = DateTime.Now };


            await _racuniService.Insert<Racuni>(racunIR);
            var racunRezultati = await _racuniService.Get<List<Racuni>>();
            var racunRezultat = racunRezultati.Last();
            var racunId = racunRezultat.RacunId;
                racun = true;
            
            
            foreach (var kArt in listaKorpaArtikli) 
            {
                KupciNarudzbeInsertRequest kupciNarudzbeIR = new KupciNarudzbeInsertRequest
                {
                    AdresaDostave = APIService.Adresa,
                    GradId = APIService.Grad.GradId,
                    Datum = DateTime.Now,
                    IsIsporucena = false,
                    KorisnickiNalogId = korisnikId
                };

                var kupciNarudzbeRezultat =  await _kupciNarudzbeService.Insert<Model.KupciNarudzbe>(kupciNarudzbeIR);
                int kupciNarudzbeId = kupciNarudzbeRezultat.KupacNarudzbeId;

                NarudzbeStavkeInsertRequest narudbeStavkeIR = new NarudzbeStavkeInsertRequest
                {
                    ArtikalId = kArt.ArtikalId,
                    Kolicina = kArt.Kolicina,
                    Popust = 0,
                    UnitCijena = kArt.Artikal.Cijena,
                    RacunId = racunId,
                    KupacNarudzbeId = kupciNarudzbeId
                };
                _ukupno += kArt.Kolicina * kArt.Artikal.Cijena;

                var narudzbeStavkeRezultat = await _narudzbeStavkeService.Insert<Model.NarudzbeStavke>(narudbeStavkeIR);
            }

            foreach(var kArt in listaKorpaArtikli) 
            {
                await _korpeArtikliService.Update<Model.KorpeArtikli>(kArt.KorpaArtikliId, new KorpeArtikliUpdateRequest() { Kolicina = 0 });
            }


            await _racuniService.Update<Model.Racuni>(racunId, new RacuniUpdateRequest() { Iznos = _ukupno });

            var listaStavki = await _narudzbeStavkeService.Get<List<Model.NarudzbeStavke>>(new NarudzbeStavkeSearchObject
            {
                RacunId = racunId
            });

            foreach(var stavka in listaStavki) 
            {
                narudzbaStavke.Add(stavka);
            }
        }




        private void PerformOk()
        {
            
        }
    }
}
