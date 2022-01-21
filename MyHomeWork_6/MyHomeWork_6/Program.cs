using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {


            var procList = Process.GetProcesses();
            foreach (var proc in procList)
            {
                Console.WriteLine($"ID = {proc.Id} Name = {proc.ProcessName}");
            }
            Console.Write("name = ");
            var name = Console.ReadLine();
            try
            {
                procList.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                Console.WriteLine($"{name} удален!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Процесс {name} не найден!");
            }
        }
    }
}