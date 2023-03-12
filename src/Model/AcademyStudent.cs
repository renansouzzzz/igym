using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym.src.Model
{
    internal class AcademyStudent
    {
        private int id;

        private string name;
        public string Name
        { get; set; }

        private int age;
        public int Age
        { get; set; }

        private string _registration;
        public Registration Registration
        { get; set; }

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
                "\nRegistro: " + Registration;
        }
    }
}
