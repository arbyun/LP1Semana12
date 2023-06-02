using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            int item = 4;
            
            var result = BeforeUtils.GetTheOnesBefore(numbers, item);

            Console.WriteLine("Numbers before " + item + ":");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            
            List<DateTime> dates = new List<DateTime>
            {
                new DateTime(2023, 1, 1),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 3, 1),
                new DateTime(2023, 4, 1),
                new DateTime(2023, 5, 1),
                new DateTime(2023, 6, 1)
            };
            DateTime date = new DateTime(2023, 4, 1);

            var result2 = BeforeUtils.GetTheOnesBefore(dates, date);

            Console.WriteLine("Dates before " + date + ":");
            foreach (var dt in result2)
            {
                Console.WriteLine(dt.ToShortDateString());
            }

            Console.ReadLine();
        }
    }
}
