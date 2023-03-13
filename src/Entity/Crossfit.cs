using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym.src.Entity
{
    internal class Crossfit : AcademyStudent
    {
        private string trainingSheet;
        public string TrainingSheet { get; private set; }

        public Crossfit(string name, int age, Registration registration) : base(name, age, registration)
        {
            
        }
    }
}
