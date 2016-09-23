using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepCounter.Models
{
    public class Goals
    {
        public string Steps { get; set; }
        public string Distance { get; set; }
        public string Calories { get; set; }

        public Goals(string steps, string distance, string calories)
        {
            Steps = steps;
            Distance = distance;
            Calories = calories;
        }
    }
}
