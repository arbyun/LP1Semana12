using System;

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

        }
    }
}
