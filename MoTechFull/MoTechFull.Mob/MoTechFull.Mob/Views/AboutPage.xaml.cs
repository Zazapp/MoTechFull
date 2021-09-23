using MoTechFull.Mob.ViewModels;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoTechFull.Mob.Views
{
    public partial class AboutPage : ContentPage
    {
        private AboutViewModel model = null;
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = model = new AboutViewModel();
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();
        }


        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KorpaShowPage());
        }

    }
}