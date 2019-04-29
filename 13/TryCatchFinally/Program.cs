using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dividend = random.Next();
            Console.WriteLine($"Divide {dividend} by a divisor.");

            try
            {
                Console.Write($"Input a divisor? ");
                string integerString = Console.ReadLine();
                int integer = int.Parse(integerString);

                double result = dividend / (double)integer;

                Console.WriteLine($"Result: {result}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Argument is null");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Integer format is wrong");
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number is too huge to be an integer");
                Console.WriteLine(e);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("The dividend is being divided by 0");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally always runs regardless of there was an exception or not");
            }
        }
    }
}
