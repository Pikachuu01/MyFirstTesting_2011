using System;
using System.IO;

namespace Homework_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateNow");

            DateTime dateTime = DateTime.Now;
            
            string DateNow = Convert.ToString(dateTime);
            
            File.AppendAllText(path: "startup.txt", contents: DateNow + "||");

            if (File.Exists(path: "startup.txt"))
            {
                System.Console.WriteLine("File exists!");

            }
            string loadedtext = File.ReadAllText(path: "startup.txt");
            
            System.Console.WriteLine(loadedtext);

            System.Console.WriteLine();

            return;
        }
    }
}
