﻿using MoTechFull.Mob.Services;
using MoTechFull.Mob.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoTechFull.Mob
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
