using igym.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static igym.Model.RegistrationType;

namespace iGym.src.Test
{
    public class Program
    {
        public static void Main()
        {

            AcademyStudent aluno = new AcademyStudent("Renan", 23,
                new Registration(1, DateTime.UtcNow, BodyBuilding));

            Console.WriteLine(aluno.toString());
        }
    }
}
