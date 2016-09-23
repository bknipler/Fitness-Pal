using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepCounter.Models
{
    public class Human
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; set; }

        public Human(string name, double weight, double height)
        {
            Weight = weight;
            Height = height;
            Name = name;
            BMI = weight / (height * height);
        }
    }
}
