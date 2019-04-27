using System;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Increment(num);

            Console.WriteLine(num);

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Increment(nums);

            Console.WriteLine(string.Join(", ", nums));

            Vector vector = new Vector(0, 0);

            Increment(vector);

            Console.WriteLine($"{vector.X} {vector.Y}");
        }

        public static void Increment(int num)
        {
            num++;
        }

        public static void Increment(int[] nums)
        {
            for (int i = 0; i < nums.Length; i ++)
            {
                nums[i]++;
            }
        }

        public static void Increment (Vector vector)
        {
            vector.X++;
            vector.Y++;
        }
    }
}
