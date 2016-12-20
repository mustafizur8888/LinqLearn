using System.Collections.Generic;

namespace D1E2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    Name = "Rasel",
                    Age = 20
                },
                new Student()
                {
                    ID = 2,
                    Name = "Mustafiz", 
                    Age = 23
                },
                new Student()
                {
                    ID = 3,
                    Name = "NK",
                    Age = 45
                },
                new Student()
                {
                    ID = 4,
                    Name = "TH",
                    Age = 50
                },
                new Student()
                {
                    ID = 5,
                    Name = "HP",
                    Age = 35
                }
            };



        }
    }


    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
