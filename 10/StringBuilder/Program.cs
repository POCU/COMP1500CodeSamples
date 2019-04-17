using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 1000;
            StringBuilder builder = new StringBuilder(CAPACITY);
            builder.Append("Hello World!");
            builder.AppendLine(" Welcome to COMP1500!");
            builder.AppendLine("Are you having fun yet?");

            Console.WriteLine(builder.ToString());

            builder.Insert(12, " Going to insert this here.");

            Console.WriteLine(builder.ToString());

            builder.Replace(" Going to insert this here.", " And replace this.");

            Console.WriteLine(builder.ToString());

            builder.Remove(12, 19);

            Console.WriteLine(builder.ToString());

            builder.Clear();

            Console.WriteLine(builder.ToString());
        }
    }
}
