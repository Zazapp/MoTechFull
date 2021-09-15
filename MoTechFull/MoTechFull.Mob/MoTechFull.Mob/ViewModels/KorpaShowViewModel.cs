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
    public class KorpaShowViewModel : BaseViewModel
    {

        private readonly APIService _artikliService = new APIService("Artikal");
        private readonly APIService _korpeService = new APIService("Korpa");
        private readonly APIService _korisniciService = new APIService("KorisnickiNalog");
        private readonly APIService _korpeArtikliService = new APIService("KorpeArtikli");
        public KorpaShowViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<KorpeArtikli> korpaArtikli{ get; set; } = new ObservableCollection<KorpeArtikli>();
        public ICommand InitCommand { get; set; }
        int korisnikId = 0;
        int korpaId = 0;
        public async Task Init()
        {
            var listKorisnika = await _korisniciService.Get<List<Model.KorisnickiNalozi>>();
            korisnikId = listKorisnika.Where(q => q.KorisnickoIme == APIService.Username && q.Lozinka == APIService.Password).Select(w => w.KorisnickiNalogId).FirstOrDefault();

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

              var korpaA = await _korpeArtikliService.Get<List<Model.KorpeArtikli>>
               (new KorpeArtikliSearchObject() { KorpaId = korpaId, IncludeListArtikal = true, IncludeListKorpa = true });

            korpaArtikli.Clear();
            foreach(var ka in korpaA) 
            {
                korpaArtikli.Add(ka);
            }
        }
    }
}
