using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo[] foos = new Foo[]
            {
                new Foo(1),
                new Foo(2),
                new Foo(3)
            };

            Foo foo1 = First(foos, 2);

            if (foo1 == null)
            {
                Console.WriteLine($"foo1 is null!");
            }
            else
            {
                Console.WriteLine($"foo1: {foo1.Number}");
            }

            Foo foo2 = First(foos, 4);

            if (foo2 == null)
            {
                Console.WriteLine($"foo2 is null!");
            }
            else
            {
                Console.WriteLine($"foo2: {foo2.Number}");
            }

            Bar[] bars = new Bar[]
            {
                new Bar(1),
                new Bar(2),
                new Bar(3)
            };

            //Bar bar1 = First(bars, 2);
            Bar? bar2 = First(bars, 2);

            if (bar2 == null)
            {
                Console.WriteLine($"bar2 is null!");
            }
            else
            {
                Console.WriteLine($"bar2: {bar2.Value.Number}");
            }

            Bar? bar3 = First(bars, 4);

            if (bar3 == null)
            {
                Console.WriteLine($"bar3 is null!");
            }
            else
            {
                Console.WriteLine($"bar3: {bar3.Value.Number}");
            }
        }

        public static Foo First(Foo[] foos, int number)
        {
            foreach (Foo foo in foos)
            {
                if (foo.Number == number)
                {
                    return foo;
                }
            }

            return null;
        }

        public static Bar? First(Bar[] bars, int number)
        {
            foreach (Bar bar in bars)
            {
                if (bar.Number == number)
                {
                    return bar;
                }
            }

            return null;
        }
    }
}
