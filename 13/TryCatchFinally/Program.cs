using System;

namespace TryCatchFinally
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int dividend = random.Next();
            Console.WriteLine($"Divide {dividend} by a divisor.");

            try
            {
                Console.Write($"Input a divisor? ");
                string integerString = Console.ReadLine();
                int divisor = int.Parse(integerString);

                if (divisor == 10)
                {
                    throw new IntegerIs10Exception("The input integer is 10!!");
                }

                int result = dividend / divisor;

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
            catch (IntegerIs10Exception e)
            {
                Console.WriteLine("The divisor is 10. Oh noez!!");
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("The dividend is being divided by 0");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally clause always runs regardless of whether or not there was an exception");
            }
        }
    }
}
