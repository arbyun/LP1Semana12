using System;

namespace MyEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> guarda3String = new Guarda3<string>();
            guarda3String.SetItem(0, "Item 1");
            guarda3String.SetItem(1, "Item 2");
            guarda3String.SetItem(2, "Item 3");

            Console.WriteLine("Guarda3<string> items:");
            foreach (var item in guarda3String)
            {
                Console.WriteLine(item);
            }

            Guarda3<float> guarda3Float = new Guarda3<float>();
            guarda3Float.SetItem(0, 1.23f);
            guarda3Float.SetItem(1, 4.56f);
            guarda3Float.SetItem(2, 7.89f);

            Console.WriteLine("Guarda3<float> items:");
            foreach (var item in guarda3Float)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
