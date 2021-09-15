using MoTechFull.Mob.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoTechFull.Mob.Services
{
    public class CartService
    {
        public static Dictionary<int, ArtikliDetailViewModel> Cart = new Dictionary<int, ArtikliDetailViewModel>();
    }
}
