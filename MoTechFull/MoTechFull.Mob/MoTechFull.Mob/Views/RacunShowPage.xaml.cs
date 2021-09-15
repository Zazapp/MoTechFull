using MoTechFull.Model;
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
    public partial class RacunShowPage : ContentPage
    {
        public RacunShowPage(Gradovi grad, string adresa)
        {
            InitializeComponent();
            App.Current.MainPage.DisplayAlert(adresa, grad.Naziv, "OK");
        }
    }
}