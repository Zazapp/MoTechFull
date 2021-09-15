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
    public partial class KorpaShowPage : ContentPage
    {
        private KorpaShowViewModel model = null;
        public KorpaShowPage()
        {
            InitializeComponent();
            BindingContext = model = new KorpaShowViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            return;
        }
    }
}