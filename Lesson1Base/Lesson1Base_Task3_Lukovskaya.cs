using System;

namespace Lesson1Base_Task3_Lukovskaya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите координату x1 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату y1 ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату x2 ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату y2 ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{r:F2}");
        }
    }
}
