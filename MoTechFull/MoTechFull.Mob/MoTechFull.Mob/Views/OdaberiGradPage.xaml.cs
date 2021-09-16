using MoTechFull.Mob.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoTechFull.Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OdaberiGradPage : ContentPage
    {
        OdaberiGradViewModel model = null;
        
        public OdaberiGradPage()
        {
            InitializeComponent();
            BindingContext = model = new OdaberiGradViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            if(model.GGrad!=null && model.AAdresa != "") 
            {
                await Navigation.PushAsync(new RacunShowPage());
            }
            else 
            {
                await App.Current.MainPage.DisplayAlert("Nije uspješno", "Polja su obavezna", "OK");
            }
        }
    }
}