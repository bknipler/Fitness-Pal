using System;
using System.ComponentModel;
using System.Dynamic;
using System.Windows.Input;
using StepCounter.Models;
using Xamarin.Forms;

namespace StepCounter.ViewModels
{
    public class GoalsViewModel : INotifyPropertyChanged
    {
        private string _distanceLabel;
        private string _caloriesLabel;
        private string _stepsLabel;
        private string _currentStepsLabel;
        private string _currentDistanceLabel;
        private string _currentCaloriesLabel;

        public string Banner { get; set; }
        public string GoalLabel { get; set; }

        public string EntrySteps { get; set; }

        public string EntryDistance { get; set; }

        public string EntryCalories { get; set; }

        public string EntryWeight { get; set; }

        public string GoalsLabel { get; set; }

        public string CurrentLabel { get; set; }


        public string CurrentStepsLabel
        {
            get { return _currentStepsLabel; }
            set
            {
                _currentStepsLabel = value;
                OnPropertyChanged("CurrentStepsLabel");

            }
        }

        public string CurrentDistanceLabel
        {
            get { return _currentDistanceLabel; }
            set
            {
                _currentDistanceLabel = value;
                OnPropertyChanged("CurrentDistanceLabel");

            }
        }

        public string CurrentCaloriesLabel
        {
            get { return _currentCaloriesLabel; }
            set
            {
                _currentCaloriesLabel = value;
                OnPropertyChanged("CurrentCaloriesLabel");

            }
        }

        public string DistanceLabel
        {
            get { return _distanceLabel; }
            set
            {
                _distanceLabel = value;
                OnPropertyChanged("DistanceLabel");
            }
        }

        public string CaloriesLabel
        {
            get { return _caloriesLabel; }
            set
            {
                _caloriesLabel = value;
                OnPropertyChanged("CaloriesLabel");
            }
        }

        public string StepsLabel
        {
            get { return _stepsLabel; }
            set
            {
                _stepsLabel = value;
                OnPropertyChanged("StepsLabel");
            }
        }

        public ICommand GoalsCommand { protected set; get; }
        public ICommand Home { protected set; get; }

        public GoalsViewModel()
        {
            Banner = "banner.png";
            GoalLabel = "Goal:";

            StepsLabel = "0";
            DistanceLabel = "0";
            CaloriesLabel = "0";

            CurrentLabel = "Current: ";
            GoalsLabel = "Goals: ";

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                CurrentStepsLabel = DependencyService.Get<IStepCounterDependency>().Steps();

                string temp = DependencyService.Get<IStepCounterDependency>().Steps();
                double steps = Convert.ToDouble(temp);
                double KM = steps / 1320;
                string kilometers = Convert.ToString(KM);
                CurrentDistanceLabel = kilometers;

                return true;
            });

            CurrentCaloriesLabel = "0";

            Home = new Command(HomePage);


            GoalsCommand = new Command(GoalView);
        }

        public void HomePage()
        {
            Application.Current.MainPage = new Views.Master();
        }

        public void GoalView()
        {
            Goals Goal = new Goals(EntrySteps, EntryDistance, EntryCalories);

            StepsLabel = Goal.Steps;
            DistanceLabel = Goal.Distance;
            CaloriesLabel = Goal.Calories;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}