using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StepCounter.Views;
using Xamarin.Forms;

namespace StepCounter.ViewModels
{
    public class MasterViewModel
    {
        public ICommand Goals { protected set; get; }
        public ICommand Health { protected set; get; }
        public ICommand Tips { protected set; get; }


        public MasterViewModel()
        {
            Goals = new Command(GoalsPage);
            Health = new Command(HealthPage);
            Tips = new Command(TipsPage);
        }

        public void GoalsPage()
        {
            Application.Current.MainPage = new Goals();
        }

        public void HealthPage()
        {
            Application.Current.MainPage = new HealthIndicator();
        }

        public void TipsPage()
        {
            Application.Current.MainPage = new FitnessTips();
        }
    }
}
