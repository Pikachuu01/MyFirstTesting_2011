using System;

namespace Homework_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " ";
            s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
        }
    }
}
