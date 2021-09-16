using MoTechFull.Mob.Services;
using MoTechFull.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class OdaberiGradViewModel:BaseViewModel
    {

        private readonly APIService _gradoviService = new APIService("Grad");
        public string AAdresa;
        public Gradovi GGrad;
        public OdaberiGradViewModel()
        {
            AAdresa = APIService.Adresa;
            GGrad = APIService.Grad;
            UpdateAdresa = new Command(UpdateGrad);
            InitCommand = new Command(async () => await Init());
        }

        private async void UpdateGrad()
        {
            APIService.Adresa = Adresa;
            APIService.Grad = SelectedGrad;
            
            if(Adresa!="" && SelectedGrad != null) 
            {
                await App.Current.MainPage.DisplayAlert("Uspjeh", "Lokacija postavljena", "OK");
            }
        }

        public ObservableCollection<Gradovi> GradoviList { get; set; } = new ObservableCollection<Gradovi>();

        public string Adresa
        {
            get { return AAdresa; }
            set
            {
                SetProperty(ref AAdresa, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public Gradovi SelectedGrad
        {
            get { return GGrad; }
            set
            {
                SetProperty(ref GGrad, value);
                if (value == null)
                {
                    InitCommand.Execute(null);
                }

            }
        }


        public async Task Init()
        {

            if (GradoviList.Count == 0)
            {
                var gradovi = await _gradoviService.Get<List<Gradovi>>();

                foreach (var grad in gradovi)
                {
                    GradoviList.Add(grad);
                }
            }
        }

        public Command UpdateAdresa { get; }
        public Command InitCommand { get; }

        
    }
}
