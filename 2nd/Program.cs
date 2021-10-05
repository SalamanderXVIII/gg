using System;

namespace _2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());
            double p = Math.Sqrt(x * x + y * y);
            double f = Math.Atan(x / y) * 57.296;
            Console.WriteLine("p = {0:F1}", p);
            Console.WriteLine("Градусы = {0:F1}", f);
        }
    }
}
