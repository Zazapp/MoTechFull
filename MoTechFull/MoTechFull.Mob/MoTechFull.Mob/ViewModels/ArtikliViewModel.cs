﻿using MoTechFull.Mob.Services;
using MoTechFull.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class ArtikliViewModel:BaseViewModel
    {
        private readonly APIService _artikliService = new APIService("Artikal");
        private readonly APIService _kategorijeService = new APIService("Kategorija");


        public ArtikliViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Artikli> ArtikliList { get; set; } = new ObservableCollection<Artikli>();
        public ObservableCollection<Kategorije> KategorijeList { get; set; } = new ObservableCollection<Kategorije>();
        Kategorije _selectedKategorija = null;

        public Kategorije SelectedKategorija
        {
            get { return _selectedKategorija; }
            set
            {
                SetProperty(ref _selectedKategorija, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (KategorijeList.Count == 0)
            {
                var kategorijeList = await _kategorijeService.Get<List<Kategorije>>(null);

                foreach (var kategorije in KategorijeList)
                {
                    KategorijeList.Add(kategorije);
                }
            }

            if (SelectedKategorija != null)
            {
                ArtikliSearchObject searchRequest = new ArtikliSearchObject();
                searchRequest.KategorijaId = SelectedKategorija.KategorijaId;

                var list = await _artikliService.Get<IList<Artikli>>(searchRequest);
                ArtikliList.Clear();
                foreach (var item in list)
                {
                    ArtikliList.Add(item);
                }
            }

        }
    }
}
