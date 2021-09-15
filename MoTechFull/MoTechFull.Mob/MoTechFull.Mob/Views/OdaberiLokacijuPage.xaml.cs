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
    public partial class OdaberiLokacijuPage : ContentPage
    {
        OdaberiGradViewModel model = null;
        public OdaberiLokacijuPage()
        {
            InitializeComponent();
            BindingContext = model = new OdaberiGradViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}