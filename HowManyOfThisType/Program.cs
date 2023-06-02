using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> collection = new List<object>
            {
                "string 1",
                123,
                "string 2",
                456,
                "string 3"
            };
            
            int count = Checker.HowManyOfType<string>(collection);
            Console.WriteLine("Number of strings in the collection: " + count);

            count = Checker.HowManyOfType<int>(collection);
            Console.WriteLine("Number of integers in the collection: " + count);

            Console.ReadLine();
        }
    }
}
