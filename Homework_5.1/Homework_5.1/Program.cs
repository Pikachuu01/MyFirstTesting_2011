using System;
using System.IO;

namespace Homework_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");

            string usertext = Console.ReadLine();

            File.WriteAllText(path: "readme.txt", contents: usertext);

            if (File.Exists(path: "readme.txt"))
            {
                System.Console.WriteLine("File exists!");
            }

            return;
        }
    }
}
