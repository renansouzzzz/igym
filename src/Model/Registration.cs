using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym.src.Model
{
    internal class Registration
    {
        private int id;
        private long numberRegistration;
        private DateTime registrationAt;
        private RegistrationType registrationType;

        public Registration(long numberRegistration, DateTime registrationAt, RegistrationType registrationType)
        {
            this.numberRegistration = numberRegistration;
            this.registrationAt = DateTime.Now;
            this.registrationType = registrationType;
        }

    }
}
