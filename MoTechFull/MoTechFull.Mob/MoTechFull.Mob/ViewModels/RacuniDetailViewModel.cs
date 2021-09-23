using MoTechFull.Mob.Services;
using MoTechFull.Model;
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
    public class RacuniDetailViewModel:BaseViewModel
    {
        private readonly APIService _korpeService = new APIService("Korpa");
        private readonly APIService _korisniciService = new APIService("KorisnickiNalog");
        private readonly APIService _korpeArtikliService = new APIService("KorpeArtikli");
        private readonly APIService _racuniService = new APIService("Racun");
        private readonly APIService _kupciNarudzbeService = new APIService("KupacNarudzbe");
        private readonly APIService _narudzbeStavkeService = new APIService("NarudzbaStavke");

        public RacuniDetailViewModel() 
        {
            InitCommand = new Command(Init);
        }

        public Racuni Racun { get; set; }
        public Command InitCommand { get; }
        public string _ime = "";

        public string  Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        public ObservableCollection<NarudzbeStavke> narudzbaStavke { get; set; } = new ObservableCollection<NarudzbeStavke>();

        public async void Init() 
        {

            var listaKorisnika = await _korisniciService.Get<List<Model.KorisnickiNalozi>>();
            Ime = listaKorisnika.Where(q => q.KorisnickiNalogId == Racun.KorisnickiNalogId).Select(w => w.KorisnickoIme).FirstOrDefault();

            var listaStavki = await _narudzbeStavkeService.Get<List<Model.NarudzbeStavke>>(new NarudzbeStavkeSearchObject
            {
                RacunId = Racun.RacunId,
                IncludeListArtikal = true
            });

            narudzbaStavke.Clear();
            if (listaStavki.Count > 0) 
            {
                foreach(var stavka in listaStavki) 
                {
                    narudzbaStavke.Add(stavka);
                }
            }
        }
    }
}
