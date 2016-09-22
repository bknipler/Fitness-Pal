using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Hardware;
using Android.Content.PM;

namespace StepCounter.Droid
{
    [Activity(Label = "StepCounter", Icon = "@drawable/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
    ScreenOrientation = ScreenOrientation.Portrait)]
    public class StepCountSensors : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ISensorEventListener, INotifyPropertyChanged
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
        protected override void OnStart()
        {
            //Call the method to check the user's APi is 19 or above.
            base.OnStart();
            if (!Utils.IsKitKatWithStepCounter(PackageManager))
            {
                return;
            }

            //If user's APi is above 19 register a listener for the StepCounter sensor.
            RegisterListeners(SensorType.StepCounter);
        }

        //Registers Listeners.
        void RegisterListeners(SensorType sensorType)
        {
            var sensorManager = (SensorManager)GetSystemService(Context.SensorService);
            var sensor = sensorManager.GetDefaultSensor(sensorType);

            sensorManager.RegisterListener(this, sensor, SensorDelay.Normal);
            Console.WriteLine("Sensor listener registered of type: " + sensorType);
        }

        //Unregisters Listerners.
        void UnregisterListeners()
        {

            var sensorManager = (SensorManager)GetSystemService(Context.SensorService);
            sensorManager.UnregisterListener(this);
            Console.WriteLine("Sensor listener unregistered.");
        }

        //Calls the method to unregister Listeners on destroy.
        protected override void OnDestroy()
        {
            base.OnDestroy();
            UnregisterListeners();
        }

        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            //Do nothing
        }

        //Adds the steps detected
        public void AddSteps(int count)
        {
            //If no steps have been recored yet then make lastSteps equal to count.
            if (lastSteps == 0)
            {
                lastSteps = count;
            }

            //the new amount of steps
            newSteps = count - lastSteps;

            //makes sure newSteps always has a value
            if (newSteps < 0)
                newSteps = 1;
            else if (newSteps > 100)
                newSteps = 1;

            //Makes last steps equal to the count.
            lastSteps = count;
        }

        static int newSteps = 0;
        static int lastSteps = 0;

        //Calculates the total steps, this method is passed onto the dependency.
        public static int totalSteps()
        {
            int steps = lastSteps;
            return steps;
        }

        //Does an action everytime the sensor listener detects a change.
        public void OnSensorChanged(SensorEvent e)
        {
            //switch between the two sensor types
            switch (e.Sensor.Type)
            {
                case SensorType.StepCounter:
                    OnPropertyChanged("OnSensorChanged");

                    //makes sure lastSteps isn't negative.
                    if (lastSteps < 0)
                        lastSteps = 0;

                    //Gets the amount of steps
                    var count = (int)e.Values[0];

                    //If count is negative then switch to the other sensor, since it handles negs better.
                    if (count < 0)
                    {
                        UnregisterListeners();
                        RegisterListeners(SensorType.StepDetector);
                        count = lastSteps + 3;
                    }

                    //else begin the AddSteps function.
                    AddSteps(count);

                    break;
                case SensorType.StepDetector:
                    count = lastSteps + 1;
                    AddSteps(count);
                    break;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}