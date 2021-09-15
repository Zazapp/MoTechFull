using MoTechFull.Mob.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MoTechFull.Mob.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}