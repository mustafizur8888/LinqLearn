using System;
using System.Collections.Generic;
using System.Linq;

namespace D1E2
{
    class Program
    {
        static void Main(string[] args)
        //var students = from x in Student.GetStudentList()
        //               where x.Age>30
        {
            //sql like syntax
            //               select x;


            // lamda syntax
            // var students = Student.GetStudentList().OrderBy(x => x.Age);
            //var students = new Student().GetStudentList().Where(x => x.Age > 30).Select(x => new
            //{
            //    AlisName = x.Name,
            //    Id = x.Id
            //});

            var a = new[] { 1, 5, 7, 3, 9 };
            var s = new[] { "a", "b", "c", "d" };

            var sList = new Student().GetStudentList();

            Student firstOrDefault = sList.FirstOrDefault();

            if (firstOrDefault != null)
                Console.WriteLine("Name " + firstOrDefault.Name);
            else
                Console.WriteLine("Student Not Found");


            Console.WriteLine("a :" + a.FirstOrDefault(aa => aa % 2 == 0));

            Console.WriteLine("s : " + s.FirstOrDefault(x => x.Contains("e")));




        }
    }


    class Student
    {
        private readonly List<Student> _students;

        public Student()
        {
            _students = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Student> GetStudentList()
        {
            _students.Add(new Student()
            {
                Id = 1,
                Name = "Rasel",
                Age = 20
            });
            _students.Add(new Student()
            {
                Id = 2,
                Name = "Mustafiz",
                Age = 23
            });

            _students.Add(new Student()
            {
                Id = 3,
                Name = "NK",
                Age = 45
            });
            _students.Add(
                new Student()
                {
                    Id = 4,
                    Name = "TH",
                    Age = 50
                });
            _students.Add(
                new Student()
                {
                    Id = 5,
                    Name = "HP",
                    Age = 35
                }
                );


            return _students;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}
