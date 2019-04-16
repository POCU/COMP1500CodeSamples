using System;
using System.IO;

namespace ParseTextMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string textMessage = File.ReadAllText(@"TextMessage.txt");

            string[] lines = textMessage.Split('\n');

            string[] dateTimeString = lines[1].Split(' ');
            string nameOfDay = dateTimeString[0];

            string[] date = dateTimeString[1].Split('-');

            int year = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int day = int.Parse(date[0]);

            string[] time = dateTimeString[2].Split(':');

            int hours = int.Parse(time[0]);
            int mins = int.Parse(time[1]);
            float seconds = float.Parse(time[2]);

            string email = lines[2].Trim();

            string courseCode = lines[3].Replace("Course", "").Trim();
            string term = lines[4].Replace("Term", "").Trim();

            Console.WriteLine($"Name of Day: {nameOfDay}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Month: {month}");
            Console.WriteLine($"Day: {day}");
            Console.WriteLine($"Hours: {hours}");
            Console.WriteLine($"Minutes: {mins}");
            Console.WriteLine($"Seconds: {seconds}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Course Code: {courseCode}");
            Console.WriteLine($"Term: {term}");
        }
    }
}
