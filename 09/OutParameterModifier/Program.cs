using System;

namespace OutParameterModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"true\" or \"false\":");
            string booleanString = Console.ReadLine();

            if (bool.TryParse(booleanString, out bool b))
            {
                Console.WriteLine($"Successfully parsed: {b}");
            }
            else
            {
                Console.WriteLine("Cannot be parsed to boolean");
            }

            Console.WriteLine("Enter an integer:");
            string intString = Console.ReadLine();

            if (int.TryParse(intString, out int number))
            {
                Console.WriteLine($"Successfully parsed: {number}");
            }
            else
            {
                Console.WriteLine("Cannot be parsed to integer");
            }

            int someNumber = 5;

            if (TryGetIntegerGreaterThan(someNumber, out int randomNumber))
            {
                Console.WriteLine($"Great! {randomNumber} > {someNumber}");
            }
            else
            {
                Console.WriteLine($"Failed to get an integer greater than {someNumber}");
            }
        }

        static bool TryGetIntegerGreaterThan(int input, out int output)
        {
            var random = new Random();

            output = random.Next(0, 10);

            return output > input;
        }
    }
}
