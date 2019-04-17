using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ELEMENTS_COUNT = 10;

            List<int> list = new List<int>();
            for (int i = 0; i < ELEMENTS_COUNT; i++)
            {
                list.Add(i);
            }

            Console.WriteLine($"[ {string.Join(", ", list)} ]");

            List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine($"[ {string.Join(", ", list2)} ]");

            Console.WriteLine($"First element: {list[0]}");
            Console.WriteLine($"Last element: {list[list.Count - 1]}");

            list.Insert(2, 2);

            Console.WriteLine($"[ {string.Join(", ", list)} ]");

            list.Remove(2);

            Console.WriteLine($"[ {string.Join(", ", list)} ]");

            bool bContains5 = list.Contains(5);

            Console.WriteLine($"Contains 5? {bContains5}");

            bool bContains10 = list.Contains(10);

            Console.WriteLine($"Contains 10? {bContains10}");

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
