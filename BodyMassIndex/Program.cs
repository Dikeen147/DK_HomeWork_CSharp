using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Работа Долгова Константина.
             
                Ввести вес и рост человека. 
                Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
                где m — масса тела в килограммах, h — рост в метрах.
             */
            Console.WriteLine("Программа вывода индекса массы тела.\n");
            Console.Write("Введите массу тела в кг: ");

            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост в см: ");

            double height = Convert.ToDouble(Console.ReadLine());

            height = height / 100;

            double result = weight / (height * height);

            Console.WriteLine($"Индекс массы тела (ИМТ) равен: {result:F2}");
        }
    }
}
