using System;

namespace InfiniteWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("input: ");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                if (input == 0)
                {
                    break;
                }

                Console.WriteLine("Number in hex: 0x{0:x}", input);
            }
        }
    }
}
