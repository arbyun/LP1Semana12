using System;

namespace JustLikeACollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> guarda3String = new Guarda3<string>
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };

            Console.WriteLine("Guarda3<string> items:");
            foreach (var item in guarda3String)
            {
                Console.WriteLine(item);
            }

            Guarda3<float> guarda3Float = new Guarda3<float>
            {
                1.23f,
                4.56f,
                7.89f
            };

            Console.WriteLine("Guarda3<float> items:");
            foreach (var item in guarda3Float)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
