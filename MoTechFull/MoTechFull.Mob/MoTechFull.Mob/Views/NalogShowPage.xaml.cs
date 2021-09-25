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
    public partial class NalogShowPage : ContentPage
    {

        NalogShowViewModel model = null;
        public NalogShowPage()
        {
            InitializeComponent();
            BindingContext = model = new NalogShowViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
             model.Init();
        }
    }
}