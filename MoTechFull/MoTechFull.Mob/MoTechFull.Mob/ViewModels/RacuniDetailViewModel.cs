using MoTechFull.Mob.Services;
using MoTechFull.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class RacuniDetailViewModel
    {
        private readonly APIService _korpeService = new APIService("Korpa");
        private readonly APIService _korisniciService = new APIService("KorisnickiNalog");
        private readonly APIService _korpeArtikliService = new APIService("KorpeArtikli");
        private readonly APIService _racuniService = new APIService("Racun");
        private readonly APIService _kupciNarudzbeService = new APIService("KupacNarudzbe");
        private readonly APIService _narudzbeStavkeService = new APIService("NarudzbaStavke");

        public RacuniDetailViewModel() 
        {
            InitCommand = new Command(async () => await Init());
        }

        public Racuni Racun { get; set; }
        public ICommand InitCommand { get; }

        public ObservableCollection<NarudzbeStavke> narudzbaStavke { get; set; } = new ObservableCollection<NarudzbeStavke>();

        public async Task Init() 
        {
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
