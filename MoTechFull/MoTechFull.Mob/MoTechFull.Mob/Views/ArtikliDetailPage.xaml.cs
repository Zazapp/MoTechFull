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
    public partial class ArtikliDetailPage : ContentPage
    {
        ArtikliDetailViewModel model = null;
        public ArtikliDetailPage(Artikli artikal)
        {
            InitializeComponent();
            BindingContext = model = new ArtikliDetailViewModel() { Artikal = artikal };
        }
    }
}