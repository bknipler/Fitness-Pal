using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepCounter.ViewModels;
using Xamarin.Forms;

namespace StepCounter.Views
{
    public partial class Master
    {
        public Master()
        {
            InitializeComponent();
        }

        void OnButtonClickedRand(object sender, EventArgs args)
        {
            Button button = (Button) sender;
            Application.Current.MainPage = new NavigationPage(new rand());

        }
    }
}
