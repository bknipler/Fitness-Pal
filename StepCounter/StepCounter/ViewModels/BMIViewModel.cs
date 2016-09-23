using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StepCounter.Models;
using StepCounter.Views;
using Xamarin.Forms;

namespace StepCounter.ViewModels
{
    public class BMIViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //FOR THE WEIGHT ENTRY
        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        //FOR THE HEIGHT ENTRY
        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        //FOR THE NAME ENTRY
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        //FOR THE MESSAGE DISPLAY
        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }

        public ICommand CalculateBMI { get; private set; }
        public ICommand Home { protected set; get; }

        private Double bmi1;
        private Double bmi2;
        public BMIViewModel()
        {
            CalculateBMI = new Command(() => calcbmi());
            bmi1 = 0;
            bmi2 = 0;
            Home = new Command(HomePage);


        }
        private void calcbmi()
        {
            Human LabRat = new Human(Name, Weight, Height);
           
            bmi1 = Weight / Height;
            bmi2 = bmi1 / Height;
            Message = LabRat.Name + "'S BMI: " + bmi2.ToString();
            Name = null;
            Weight = 0;
            Height = 0;
            OnPropertyChanged (Message.ToString());
        }

        public void HomePage()
        {
            Application.Current.MainPage = new Master();
        }


        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

   

    
        
    }


    




