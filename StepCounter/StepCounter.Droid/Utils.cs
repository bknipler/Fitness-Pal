using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace StepCounter.Droid
{
    [Activity(Label = "Utils")]
    public class Utils : Activity
    {
        //Makes sure the users phone is API 19 (KitKat) or above - this is needed to use the sensors
        public static bool IsKitKatWithStepCounter(PackageManager pm)
        {
            // Require at least Android KitKat
            int currentApiVersion = (int)Build.VERSION.SdkInt;
            return currentApiVersion >= 19;
        }
    }
}