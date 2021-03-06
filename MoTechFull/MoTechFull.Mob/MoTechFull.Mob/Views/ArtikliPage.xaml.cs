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
    public partial class ArtikliPage : ContentPage
    {
        ArtikliViewModel model = null;
        public ArtikliPage()
        {
            InitializeComponent();
            BindingContext = model = new ArtikliViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Artikli;

            await Navigation.PushAsync(new ArtikliDetailPage(item));
        }
    }
}