using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym.src.Entity
{
    abstract class AcademyStudent
    {
        private int id;

        private string name;
        public string Name
        { get; private set; }

        private int age;
        public int Age
        { get; private set; }

        private Registration registration;
        public Registration Registration
        { get; private set; }

        public AcademyStudent(string name, int age, Registration registration)
        {

            Name = name;
            Age = age;
            Registration = registration;

        }

        public string toString()
        {
            return "Nome: " + Name +
                "\nIdade: " + Age +
                "\nNumero registro: " + Registration.NumberRegistration +
                "\nCriado em: " + Registration.RegistrationAt;
        }
    }
}
