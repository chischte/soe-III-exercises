using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            public int StudentId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int EducationId { get; set; }
        }

        //TODO Struct Education
        private struct Education
        {
            public int EducationId { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            InitialList();

            Console.WriteLine("Aufgabe 1");
            Console.WriteLine("--------------");
            //TODO Alle Studenten, die Wirtschaft studieren und über 18 Jahre alt sind. (Benützen Sie Extension Methods)
            var studentNames1 = _studentList.Where(s => s.Age > 18 && s.EducationId == 1).Select(s => s.Name);
            studentNames1.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 2");
            Console.WriteLine("--------------");
            //TODO Alle Studenten, die unter 20 Jahre alt sind. (Benützen Sie Linq und übergeben Sie das Resultat auf ein anonymes Attribut). 
            var studentNames2 = from s in _studentList
                                where s.Age < 20
                                select new { StudentenName = s.Name };
            studentNames2.ToList().ForEach(x => Console.WriteLine(x.StudentenName));
            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 3");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf. (Benützen Sie Linq-Abfrage)
            var studentsGroupByEducation1 = from s in _studentList
                                            group s by s.EducationId into sg
                                            orderby sg.Key
                                            select new { sg.Key, sg };
            foreach (var group in studentsGroupByEducation1)
            {
                Console.WriteLine("EducationId {0}:", group.Key);
                group.sg.ToList().ForEach(st => Console.WriteLine(st.Name));
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 4");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf. (Benützen Sie Linq-Abfrage)
            var studentsGroupByEducation2 = from e in _educationList
                                            join s in _studentList on e.EducationId equals s.EducationId
                                            into sg
                                            select new
                                            {
                                                EducationName = e.Name,
                                                Students = sg
                                            };
            foreach (var group in studentsGroupByEducation2)
            {
                Console.WriteLine(group.EducationName);
                group.Students.ToList().ForEach(st => Console.WriteLine(st.Name));
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 5");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf, die älter als 20 Jahre sind. (Benützen Sie Linq-Abfrage)
            var studentWithEducation = from s in _studentList
                                       join e in _educationList on s.EducationId equals e.EducationId
                                       where s.Age > 20
                                       select new
                                       {
                                           StudentName = s.Name,
                                           EdcuationName = e.Name
                                       };

            studentWithEducation.ToList().ForEach(s => Console.WriteLine("{0} is in {1}", s.StudentName, s.EdcuationName));
            Console.WriteLine("--------------");

            Console.ReadKey();
        }

        //
        private static void InitialList()
        {
            _studentList = new List<Student>() {
                new Student() { StudentId = 1, Name = "John", Age = 18, EducationId = 1 } ,
                new Student() { StudentId = 2, Name = "Steve",  Age = 21, EducationId = 1 } ,
                new Student() { StudentId = 3, Name = "Bill",  Age = 18, EducationId = 2 } ,
                new Student() { StudentId = 4, Name = "Ram" , Age = 20, EducationId = 2 } ,
                new Student() { StudentId = 5, Name = "Ron" , Age = 21, EducationId = 3 }
            };

            _educationList = new List<Education>() {
                new Education(){ EducationId = 1, Name="Wirtschaft"},
                new Education(){ EducationId = 2, Name="Medizin"},
                new Education(){ EducationId = 3, Name="Informatik"}
            };
        }
    }
}
