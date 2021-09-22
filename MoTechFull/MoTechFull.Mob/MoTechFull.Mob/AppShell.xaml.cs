using MoTechFull.Mob.ViewModels;
using MoTechFull.Mob.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MoTechFull.Mob
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ArtikliPage), typeof(ArtikliPage));
            Routing.RegisterRoute(nameof(KorpaShowPage), typeof(KorpaShowPage));
            Routing.RegisterRoute(nameof(OdaberiGradPage), typeof(OdaberiGradPage));
            Routing.RegisterRoute(nameof(OdaberiLokacijuPage), typeof(OdaberiLokacijuPage));
            Routing.RegisterRoute(nameof(RacuniShowPage), typeof(RacuniShowPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
