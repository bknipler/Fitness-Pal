using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StepCounter.Droid;

//Create Dependency so that amount of steps can be shown in xamarin forms.
[assembly: Dependency(typeof(StepCounterDependency))]
namespace StepCounter.Droid
{
    public class StepCounterDependency : IStepCounterDependency
    {
        public string Steps()
        {
            int numSteps = StepCountSensors.totalSteps();
            string steps = numSteps.ToString();
            return steps;
        }
    }
}