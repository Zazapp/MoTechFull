using MoTechFull.Mob.Services;
using MoTechFull.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class RacunShowViewModel:BaseViewModel
    {
        private readonly APIService _korpeService = new APIService("Korpa");
        private readonly APIService _korisniciService = new APIService("KorisnickiNalog");
        private readonly APIService _korpeArtikliService = new APIService("KorpeArtikli");

        public Gradovi ggrad;
        public string aadresa;
        public RacunShowViewModel() 
        {
           InitCommand = new Command(async () => await Init());
            ggrad = APIService.Grad;
            aadresa = APIService.Adresa;
        }

        public ObservableCollection<NarudzbeStavke> narudzbaStavke { get; set; } = new ObservableCollection<NarudzbeStavke>();

        int korisnikId = 0;
        int korpaId = 0;
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
        public async Task Init()
        {
            var listKorisnika = await _korisniciService.Get<List<Model.KorisnickiNalozi>>();
            korisnikId = listKorisnika.Where(q => q.KorisnickoIme == APIService.Username && q.Lozinka == APIService.Password).Select(w => w.KorisnickiNalogId).FirstOrDefault();

            KorpeSearchObject korpeS = new KorpeSearchObject()
            {
                KorisnickiNalogId = korisnikId
            };

            var listaKorpi = await _korpeService.Get<List<Korpe>>(korpeS);

            korpaId = listaKorpi.Last().KorpaId;

            
        }

    }
}
