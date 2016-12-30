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



            // ------------- Task Day 1-----------------------------------

            TaskDayOne tdone= new TaskDayOne();
            Console.WriteLine(Environment.NewLine + @"find all number in the array of numbers whice are gretter then 5 :" );
            tdone.FindNumberGreaterThenFive();
            Console.WriteLine(Environment.NewLine + @"find all number in the array of numbers whice are even Number :");
            tdone.FindEvenNumbers();
            Console.WriteLine(Environment.NewLine + @"find all number in the array of numbers whice are odd Number :");
            tdone.FindOddNumbers();
            Console.WriteLine(Environment.NewLine + @"find the top 1 number in the numbers array :");
            tdone.FindTopOneNumber();
            Console.WriteLine(Environment.NewLine + @"find the top 1 number in the numbers array which are gretter then 5:");
            tdone.FindTopOneNumberGreaterThenFive();
            Console.WriteLine(Environment.NewLine + @"find the count of number in the numbers array:");
            tdone.FindCountNumbers();

            Console.WriteLine(Environment.NewLine + @"Show only student name who's age are  gretter then 30:");
            //tdone.FindCountNumbers();

            Student std = new Student();
            var ListStd = std.GetStudentList().Where(x => x.Age > 30);
            foreach (var stud in ListStd)
            {
                Console.WriteLine("Name :"  + stud.Name + " "  + "Age : " + stud.Age);
            }
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
