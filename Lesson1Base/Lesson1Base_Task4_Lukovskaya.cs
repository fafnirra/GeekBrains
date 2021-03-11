using System;

namespace Lesson1Base_Task4_Lukovskaya
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a+" "+b);
        }
    }
}
