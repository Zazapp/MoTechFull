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
    public class RacuniShowViewModel:BaseViewModel
    {

        private readonly APIService _racuniService = new APIService("Racun");



        public RacuniShowViewModel() 
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Racuni> RacuniList { get; set; } = new ObservableCollection<Racuni>();

        int korisnikId = 0;
        int korpaId = 0;
        public double _ukupno = 0;

        Racuni _selectedRacun = null;

        public Racuni SelectedRacun
        {
            get { return _selectedRacun; }
            set
            {
                SetProperty(ref _selectedRacun, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (RacuniList.Count == 0)
            {
                var racuniL = await _racuniService.Get<List<Racuni>>(null);

                foreach (var racuni in racuniL)
                {
                    RacuniList.Add(racuni);
                }
            }

            if (SelectedRacun != null)
            {
                RacuniSearchObject searchRequest = new RacuniSearchObject();
                searchRequest.RacunId = SelectedRacun.RacunId;

                var list = await _racuniService.Get<IList<Racuni>>(searchRequest);
                RacuniList.Clear();



                foreach (var item in list)
                {
                    RacuniList.Add(item);
                }


            }
        }
    }
}
