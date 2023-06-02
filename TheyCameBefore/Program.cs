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
        }
    }
}
