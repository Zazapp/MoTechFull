using MoTechFull.Mob.Services;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class ArtikliDetailViewModel:BaseViewModel
    {
        private readonly APIService _artikliService = new APIService("Artikal");
        private readonly APIService _korpeService = new APIService("Korpa");
        private readonly APIService _korisniciService = new APIService("KorisnickiNalog");
        private readonly APIService _korpeArtikliService = new APIService("KorpeArtikli");
        public ArtikliDetailViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            SmanjiKolicinuCommand = new Command(Smanji);
            DodajUKorpu = new Command(KorpaAdd);
        }

        private async void KorpaAdd()
        {
             await KorpaAddTask();
        }

        public Artikli Artikal { get; set; }

        int korisnikId = 0;
        int korpaId = 0;
        decimal _kolicina = 0;
        public double _ukupno = 0;
        public decimal Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }
        public ICommand DodajUKorpu { get; set; }

        private async Task KorpaAddTask()
        {
            var listKorisnika = await _korisniciService.Get<List<Model.KorisnickiNalozi>>();
            korisnikId= listKorisnika.Where(q => q.KorisnickoIme == APIService.Username && q.Lozinka == APIService.Password).Select(w => w.KorisnickiNalogId).FirstOrDefault();

            KorpeSearchObject korpeS = new KorpeSearchObject()
            {
                KorisnickiNalogId = korisnikId
            };

            var listaKorpi = await _korpeService.Get<List<Korpe>>(korpeS);
            if (!listaKorpi.Any())
            {
                KorpeInsertRequest nova = new KorpeInsertRequest
                {
                    DatumDodavanja = DateTime.Now,
                    KorisnickiNalogId = korisnikId
                };
                var resultK = await _korpeService.Insert<Model.Korpe>(nova);
                korpaId = resultK.KorpaId;
            }
            else korpaId = listaKorpi.Last().KorpaId;

            var kartikli = await _korpeArtikliService.Get<List<Model.KorpeArtikli>>
                (new KorpeArtikliSearchObject() { ArtikalId = Artikal.ArtikalId,KorpaId=korpaId,IncludeListArtikal=true,IncludeListKorpa=true });

            if (kartikli.Any())
            {
                int idKart = kartikli.First().KorpaArtikliId;
                int oKolicina = kartikli.First().Kolicina;
                if (Kolicina == 0) 
                {
                    Kolicina = -1 * oKolicina;
                    await App.Current.MainPage.DisplayAlert("Izbrisano", "Izbačen iz korpe", "OK");
                }
                KorpeArtikliUpdateRequest kartUpdate = new KorpeArtikliUpdateRequest {Kolicina = (int)Kolicina+oKolicina};
                await _korpeArtikliService.Update<Model.KorpeArtikli>(idKart, kartUpdate);
            }
            else 
            {
                KorpeArtikliInsertRequest kartikal = new KorpeArtikliInsertRequest
                {
                    ArtikalId = Artikal.ArtikalId,
                    Kolicina = (int)Kolicina,
                    KorpaId = korpaId
                };

                await _korpeArtikliService.Insert<KorpeArtikli>(kartikal);
            }
            if (Kolicina < 0) { }
            else 
            {
                await App.Current.MainPage.DisplayAlert("Uspjeh", "Dodano u korpu", "OK");
            }
        }
        private void Smanji()
        {
            if (Kolicina != 0)
                Kolicina -= 1;

            _ukupno = (double)Kolicina * Artikal.Cijena;
        }
    }
}
