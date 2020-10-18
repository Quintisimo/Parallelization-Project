using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] single = System.IO.File.ReadAllLines("../../../records/single.txt");
            string[] parallel = System.IO.File.ReadAllLines("../../../records/parallel.txt");
            bool noDiff = true;

            if (single.Length != parallel.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Files do not have the same number of lines");
            }

            foreach (string line in single)
            {
                bool containsLine = parallel.Contains(line);

                if (!containsLine)
                {
                    noDiff = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Mismatched Line: {line}");
                }
            }

            if (noDiff)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Files are identical");
            }
        }
    }
}
