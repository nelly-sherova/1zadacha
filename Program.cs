using System;

namespace _1zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double sg = Math.Pow((a*b),0.5);
            Console.WriteLine($"Среднее геометрическое: {sg} ");
        }
    }
}
