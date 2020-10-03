using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        private static List<Student> _studentList;
        private static List<Education> _educationList;

        //TODO Struct Student
        private struct Student
        {
            public int StudentId { get; set; };
            public String Name { get; set; };
            public int Age { get; set; };
            public int EducationId { get; set; };

        }

        //TODO Struct Education
        private struct Education
        {
            public int EducationId { get; set; };
            public String Name { get; set; };
        }

        static void Main(string[] args)
        {
            InitialList();

            Console.WriteLine("Aufgabe 1");
            Console.WriteLine("--------------");
            //TODO Alle Studenten, die Wirtschaft studieren und über 18 Jahre alt sind. (Benützen Sie Extension Methods)
            var studentNames1 = _studentList.Where(s => s.Age > 18 && s.EducationId == 1).Select(s => s.Name);
            studentNames1.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("------");







            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 2");
            Console.WriteLine("--------------");
            //TODO Alle Studenten, die unter 20 Jahre alt sind. (Benützen Sie Linq und übergeben Sie das Resultat auf ein anonymes Attribut). 










            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 3");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf. (Benützen Sie Linq-Abfrage)











            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 4");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf. (Benützen Sie Linq-Abfrage)











            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 5");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf, die älter als 20 Jahre sind. (Benützen Sie Linq-Abfrage)












            Console.WriteLine("--------------");

            Console.ReadKey();
        }

        //TODO Listen auffüllen
        private static void InitialList()
        {
            List<Student> _studentList = new List<Student>;
            _studentList.Add(new Student(1, "John", 18, 1));
            _studentList.Add(new Student(2, "Steve", 21, 1));
            _studentList.Add(new Student(3, "Bill", 18, 2));
            _studentList.Add(new Student(4, "Ramon", 20, 2));
            _studentList.Add(new Student(5, "Roland", 21, 3));

        }
    }
}
