using System;
using System.IO;

namespace ReadAndWriteFileUsingFileStream
{
    public class Program
    {
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory();
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");

        public static void Main(string[] args)
        {
            setup();

            FileStream fsRead = File.Open(INPUT_FILE_FULL_PATH, FileMode.Open, FileAccess.Read);

            //fsRead.Write(new byte[] { 1, 2, 3 }, 0, 3);

            Console.WriteLine($"CanRead: {fsRead.CanRead}");
            Console.WriteLine($"CanWrite: {fsRead.CanWrite}");
            Console.WriteLine($"CanSeek: {fsRead.CanSeek}");

            byte[] bytes = new byte[fsRead.Length];
            fsRead.Read(bytes, 0, bytes.Length);

            fsRead.Close();

            Console.WriteLine(string.Join(", ", bytes));

            FileStream fsWrite = File.Open(OUTPUT_FILE_FULL_PATH, FileMode.Create, FileAccess.Write);

            Console.WriteLine($"CanRead: {fsWrite.CanRead}");
            Console.WriteLine($"CanWrite: {fsWrite.CanWrite}");
            Console.WriteLine($"CanSeek: {fsWrite.CanSeek}");

            fsWrite.Write(bytes, 0, bytes.Length);

            fsWrite.Close();
        }

        private static void setup()
        {
            if (File.Exists(OUTPUT_FILE_FULL_PATH))
            {
                File.Delete(OUTPUT_FILE_FULL_PATH);
            }

            if (!Directory.Exists(OUTPUT_FOLDER_PATH))
            {
                Directory.CreateDirectory(OUTPUT_FOLDER_PATH);
            }
        }
    }
}
