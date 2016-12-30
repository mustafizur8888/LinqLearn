using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1E2
{
    class TaskDayOne
    {
        //Task 1:find all number in the array of numbers whice are gretter then 5
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        public void FindNumberGreaterThenFive()
        {
            var greaterNumbers = numbers.Where(x => x > 5);
            foreach (int num in greaterNumbers)
            {
                Console.WriteLine(num);
            }


        }

        public void FindEvenNumbers()
        {
            var evenNumbers = numbers.Where(x => x % 2 == 0);
            foreach (int evenNum in evenNumbers)
            {
                Console.WriteLine(evenNum);
            }
        }

        public void FindOddNumbers()
        {
            var evenNumbers = numbers.Where(x => x % 2 != 0);
            foreach (int evenNum in evenNumbers)
            {
                Console.WriteLine(evenNum);
            }
        }

        public void FindTopOneNumber()
        {
            var topOneNumber = numbers.FirstOrDefault();
            Console.WriteLine(topOneNumber);
        }

        public void FindTopOneNumberGreaterThenFive()
        {
            var topTopGreaterFive = numbers.Where(x => x > 5).FirstOrDefault();
            Console.WriteLine(topTopGreaterFive);
        }

        public void FindCountNumbers()
        {
            var counter = numbers.Count();
            Console.WriteLine(counter);
        }
    }
}
