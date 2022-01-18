using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HomeWork_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 0...255");

            int number = Convert.ToInt32(Console.ReadLine());

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(new FileStream("number.bin", FileMode.OpenOrCreate), number);

        }
    }
}
