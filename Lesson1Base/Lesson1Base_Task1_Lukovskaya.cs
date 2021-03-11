using System;

namespace Lesson1Base_Lukovskaya.A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите фамилию ");
            string cognomen = Convert.ToString(Console.ReadLine());
            Console.Write("Введите возраст ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} {3} {4}", name, cognomen, age, height, weight);
            Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", name, cognomen, age, height, weight));
            Console.WriteLine($"{name} {cognomen} {age} {height} {weight}");
        }
    }
}