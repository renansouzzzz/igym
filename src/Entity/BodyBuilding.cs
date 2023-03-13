using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym.src.Entity
{
    internal class BodyBuilding : AcademyStudent
    {
        private string sessionTime;
        public string SessionTime { get; private set; }

        public BodyBuilding(string name, int age, Registration registration) : base(name, age, registration)
        {
        }
    }
}
