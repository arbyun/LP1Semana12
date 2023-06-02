using System;

namespace MyGenericClass
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
            Console.WriteLine(guarda3String.GetItem(0));
            Console.WriteLine(guarda3String.GetItem(1));
            Console.WriteLine(guarda3String.GetItem(2));

            Guarda3<float> guarda3Float = new Guarda3<float>();
            guarda3Float.SetItem(0, 1.23f);
            guarda3Float.SetItem(1, 4.56f);
            guarda3Float.SetItem(2, 7.89f);

            Console.WriteLine("Guarda3<float> items:");
            Console.WriteLine(guarda3Float.GetItem(0));
            Console.WriteLine(guarda3Float.GetItem(1));
            Console.WriteLine(guarda3Float.GetItem(2));

            Console.ReadLine();
        }
    }
}
