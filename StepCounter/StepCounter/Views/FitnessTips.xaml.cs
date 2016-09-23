using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepCounter.ViewModels;

using Xamarin.Forms;

namespace StepCounter.Views
{
    public partial class FitnessTips
    {
        public FitnessTips()
        {
            InitializeComponent();
            BindingContext = new FitnessTipsViewModel();
        }
    }
}
