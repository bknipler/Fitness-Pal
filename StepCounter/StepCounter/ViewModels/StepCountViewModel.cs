﻿using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace StepCounter.ViewModels
{
    public class StepCountViewModel : INotifyPropertyChanged
    {
        private string _stepCount;
        private string _stepGoal;
        private string _calorieCount;
        private string _calorieGoal;

        public string StepCount
        {
            get { return _stepCount; }
            set
            {
                _stepCount = value;
                OnPropertyChanged("StepCount");
            }
        }

        public string StepGoal
        {
            get { return _stepGoal; }
            set
            {
                _stepGoal = value;
                OnPropertyChanged("StepGoal");
            }
        }

        public string CalorieCount
        {
            get { return _calorieCount; }
            set
            {
                _calorieCount = value;
                OnPropertyChanged("CalorieCount");
            }
        }

        public string CalorieGoal
        {
            get { return _calorieGoal; }
            set
            {
                _calorieGoal = value;
                OnPropertyChanged("CalorieGoal");
            }
        }

        public string Banner { get; set; }
        public string Flame { get; set; }
        public string FootPrints { get; set; }

        public StepCountViewModel()
        {
            StepGoal = "Goal: " + "0";
            CalorieCount = "Todays Calories: " + "0";
            CalorieGoal = "Goal: " + "0";

            //Images
            Banner = "banner.png";
            Flame = "flame.png";
            FootPrints = "footsteps.png";

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                StepCount = "Todays steps: " + DependencyService.Get<IStepCounterDependency>().Steps();
                return true;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}