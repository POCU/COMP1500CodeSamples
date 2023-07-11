using System;
using System.IO;

namespace ReadAndWriteFile
{
    public class Program
    {
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory();
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE1_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");
        private static readonly string OUTPUT_FILE2_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext2.txt");

        public static void Main(string[] args)
        {
            setup();

            Console.WriteLine($"Input file is in: {INPUT_FILE_FULL_PATH}");

            string allText = File.ReadAllText(INPUT_FILE_FULL_PATH);

            Console.WriteLine("----------------------------------");
            Console.WriteLine(allText);
            Console.WriteLine("----------------------------------");

            string[] allLines = File.ReadAllLines(INPUT_FILE_FULL_PATH);

            Console.WriteLine("----------------------------------");
            foreach (string line in allLines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine($"Output file 1 is in: {OUTPUT_FILE1_FULL_PATH}");

            File.WriteAllText(OUTPUT_FILE1_FULL_PATH, allText);

            File.WriteAllLines(OUTPUT_FILE1_FULL_PATH, allLines);

            File.AppendAllLines(OUTPUT_FILE1_FULL_PATH, allLines);

            byte[] bytes = new byte[12] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100, 33 };

            File.WriteAllBytes(OUTPUT_FILE2_FULL_PATH, bytes);

            Console.WriteLine($"Output file 2 is in: {OUTPUT_FILE2_FULL_PATH}");
        }

        private static void setup()
        {
            if(File.Exists(OUTPUT_FILE1_FULL_PATH))
            {
                File.Delete(OUTPUT_FILE1_FULL_PATH);
            }

            if (File.Exists(OUTPUT_FILE2_FULL_PATH))
            {
                File.Delete(OUTPUT_FILE2_FULL_PATH);
            }

            if (!Directory.Exists(OUTPUT_FOLDER_PATH))
            {
                Directory.CreateDirectory(OUTPUT_FOLDER_PATH);
            }
        }
    }
}
