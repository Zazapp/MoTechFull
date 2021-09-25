using MoTechFull.Mob.Services;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class NalogShowViewModel:BaseViewModel
    {
        private readonly APIService _korisnickiNaloziService = new APIService("KorisnickiNalog");

        public string _username;
        public string _password1;
        public string _password2;
        public KorisnickiNalozi nalog;
        public NalogShowViewModel() 
        {
            UpdateUser = new Command(async ()=>await UpdateInfo());
            InitCommand = new Command(Init);
            _username = APIService.Username;
            _password1 = APIService.Password;
            _password2 = APIService.Password;

        }


        public string Username
        {
            get { return _username; }
            set
            {
                SetProperty(ref _username, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public string Password1
        {
            get { return _password1; }
            set
            {
                SetProperty(ref _password1, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public string Password2
        {
            get { return _password2; }
            set
            {
                SetProperty(ref _password2, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }


        private async Task UpdateInfo()
        {
            if(Username.Length>=3 && Password1.Equals(Password2) && Password1.Length >= 3) 
            {

                var Lista = await _korisnickiNaloziService.Get<List<Model.KorisnickiNalozi>>
                (new KorisnickiNaloziSearchObject() { KorisnickoIme = APIService.Username });

                KorisnickiNalozi nalog = Lista.Where(q => q.KorisnickoIme == APIService.Username && q.Lozinka == APIService.Password).FirstOrDefault();

                KorisnickiNaloziUpdateRequest novi = new KorisnickiNaloziUpdateRequest
                {
                    KorisnickoIme = Username,
                    Lozinka = Password1,
                    Tip = nalog.Tip
                };

                await _korisnickiNaloziService.Update<Model.KorisnickiNalozi>(nalog.KorisnickiNalogId, novi);
                APIService.Username = novi.KorisnickoIme;
                APIService.Password = novi.Lozinka;
                await App.Current.MainPage.DisplayAlert("Uspjeh", "Username/Password promjenjen", "OK");
            }
            else await App.Current.MainPage.DisplayAlert("Obavezno", "Polja su obavezna(3+ karaktera)", "OK");
        }

        public void Init() 
        {
            
        }
        public Command UpdateUser { get; }
        public Command InitCommand { get; }
    }
}
