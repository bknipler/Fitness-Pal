using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StepCounter.Views;
using Xamarin.Forms;

namespace StepCounter.ViewModels
{
    public class FitnessTipsViewModel : INotifyPropertyChanged
    {
        List<string> answers = new List<string> {
                "Run Forrest Run!",
                "Do you even lift?",
                "Never Skip Leg Day",
                "Squats!!!",
                "Feel the Burn!!!",
                "No.",
                "Nuh-uh.",
                "Absolutely not!",
                "I wouldn't bet on it",
                "HELL NO.",
                "Maybe",
                "Possibly...",
                "Ask again later.",
                "I can't be certain.",
                "Clouded by the Dark Side, the future is."
            };

        private string _tip;
        static Random randomAnswerSelector = new Random();

        public ICommand TipsCommand { protected set; get; }
        public ICommand Home { protected set; get; }


        public string Banner { get; set; }

        public string Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                OnPropertyChanged("Tip");
            }
        }


        public FitnessTipsViewModel()
        {
            Banner = "banner.png";
            Tip = "Click Button For a helpful fitness tip!";
            TipsCommand = new Command(RandomTip);
            Home = new Command(HomePage);
        }

        public void HomePage()
        {
            Application.Current.MainPage = new Master();
        }

        public void RandomTip()
        {
            Tip = answers[randomAnswerSelector.Next(answers.Count)];
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
