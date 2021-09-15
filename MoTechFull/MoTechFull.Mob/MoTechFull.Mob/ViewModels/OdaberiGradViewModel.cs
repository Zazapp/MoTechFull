using MoTechFull.Mob.Services;
using MoTechFull.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoTechFull.Mob.ViewModels
{
    public class OdaberiGradViewModel:BaseViewModel
    {

        private readonly APIService _gradoviService = new APIService("Grad");
        public OdaberiGradViewModel() 
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Gradovi> GradoviList { get; set; } = new ObservableCollection<Gradovi>();
        Gradovi _selectedGrad = null;

        string adress;
        public string Adresa
        {
            get { return adress; }
            set
            {
                SetProperty(ref adress, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public Gradovi SelectedGrad
        {
            get { return _selectedGrad; }
            set
            {
                SetProperty(ref _selectedGrad, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }


        public async Task Init()
        {

            if (GradoviList.Count == 0)
            {
                var gradovi = await _gradoviService.Get<List<Gradovi>>();

                foreach (var grad in gradovi)
                {
                    GradoviList.Add(grad);
                }
            }
        }


        public Command InitCommand { get; }
    }
}
