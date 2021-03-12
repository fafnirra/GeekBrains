using System;

namespace Lesson1Base_Lukovskaya
{
    class Program
    {
        static void Main(string[] args)

        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Console.ReadLine();
        }

        //1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
        //В результате вся информация выводится в одну строчку.
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) *используя вывод со знаком $.

        static void Task1()

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

        //2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h);
        //где m — масса тела в килограммах, h — рост в метрах.

        static void Task2()

        {

            Console.Write("Введите рост в метрах." +
                $"\nИспользуйте запятую для разделения метров и сантиметров, например '1,70': ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            int m = Convert.ToInt32(Console.ReadLine());

            double BMI = m / (h + h);

            Console.WriteLine($"Индекс массы тела равен: {BMI.ToString("###. ##")}" +
                $"\nНормой считаются показатели от 18,50 до 24,99 килограмм на квадратный метр." +
                $"\nЕсли результат находится вне этого диапазона, необходима консультация специалиста.");
        }

        //3. Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);

        static void Task3()

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

        //4. Написать программу обмена значениями двух переменных.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.

        static void Task4()

        {
            int x = 0;
            int y = 3;
            int z = 4;

            x = y;
            y = z;
            z = x;

            Console.WriteLine(y + " " + z);

            int a = 3;
            int b = 4;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a + " " + b);
        }

        //5.Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //Сделать задание, только вывод организуйте в центре экрана.

        static void Task5()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Анастасия Луковская, Москва");
        }
    }
}