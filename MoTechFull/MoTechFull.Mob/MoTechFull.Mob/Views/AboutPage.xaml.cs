using MoTechFull.Mob.ViewModels;
using System;
using System.ComponentModel;
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


    }
}