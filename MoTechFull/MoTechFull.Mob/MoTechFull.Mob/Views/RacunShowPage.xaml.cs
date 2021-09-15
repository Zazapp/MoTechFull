using MoTechFull.Mob.ViewModels;
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
        private RacunShowViewModel model = null;
        public RacunShowPage()
        {
            InitializeComponent();
            BindingContext = model = new RacunShowViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}