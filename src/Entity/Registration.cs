using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym.src.Entity
{
    internal class Registration
    {
        private int id;
        private long numberRegistration;
        public long NumberRegistration { get; private set; }

        private DateTime registrationAt;
        public DateTime RegistrationAt { get; private set; }

        private AcademyStudent registrationType;

        public Registration(long numberRegistration, DateTime registrationAt)
        {
            this.numberRegistration = numberRegistration;
            this.registrationAt = DateTime.Now;
        }

    }
}
