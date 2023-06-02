using System;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: dotnet run --project WriteStuff1 -- <filename>");
                return;
            }

            string filename = args[0];

            Queue<string> stringQueue = new Queue<string>();

            Console.WriteLine("Enter strings (press Enter to stop):");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                stringQueue.Enqueue(input);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    while (stringQueue.Count > 0)
                    {
                        string str = stringQueue.Dequeue();
                        writer.WriteLine(str);
                    }
                }

                Console.WriteLine($"Strings saved to {filename}");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error saving strings to file:");
                Console.WriteLine(e.Message);

            }
        }
    }
}
