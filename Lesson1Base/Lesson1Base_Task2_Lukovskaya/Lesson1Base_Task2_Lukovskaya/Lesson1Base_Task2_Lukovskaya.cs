using System;

namespace Lesson1Base_Task2_Lukovskaya
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите рост в метрах.\nИспользуйте запятую для разделения метров и сантиметров, например '1,70': ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            int m = Convert.ToInt32(Console.ReadLine());

            double BMI = m / (h + h);

            Console.WriteLine($"Индекс массы тела равен: {BMI.ToString("###. ##")}\nНормой считаются показатели от 18,50 до 24,99 килограмм на квадратный метр.\nЕсли результат находится вне этого диапазона, необходима консультация специалиста.");
        }
    }
}
