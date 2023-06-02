using System;
using System.IO;

namespace WriteStuff2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: dotnet run --project WriteStuff2 -- <filename>");
                return;
            }

            string filename = args[0];

            Console.WriteLine("Enter strings (press Enter to stop):");

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    while (true)
                    {
                        string input = Console.ReadLine();

                        if (string.IsNullOrEmpty(input))
                            break;

                        writer.WriteLine(input);
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
