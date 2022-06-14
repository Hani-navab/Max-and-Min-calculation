using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("** Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("** Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Min = (num1 + num2 - Math.Abs(num1 - num2)) / 2;
            Console.WriteLine("********************************");
            Console.Write("Min is: ");
            Console.WriteLine(Convert.ToString(Min));
            int Max=(num1 + num2+ Math.Abs(num1 - num2)) / 2;
            Console.Write("Max is: ");
             Console.WriteLine(Convert.ToString(Max));
             Console.ReadKey();
        }
    }
}
