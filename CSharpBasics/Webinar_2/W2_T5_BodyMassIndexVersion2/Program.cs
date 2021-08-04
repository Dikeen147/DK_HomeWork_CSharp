using System;

namespace W2_T5_BodyMassIndexVersion2
{
    class Program
    {
        /*
         Работа Долгова Константина

        Задача 5.
        а) Написать программу, которая запрашивает массу и рост человека, 
        вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

         */
        static string MassBodyIndex(int weight, double height)
        {
            height = Math.Pow(height / 100, 2);

            double result = weight / height;
            double minWeight = 18.6 * height;
            double maxWeight = 25 * height;
            string option = result > 25 ? "сбросить" : "набрать";
            string resultStr = "";
            string diagnosis = $"\nВаш нормальный вес от {minWeight:F2} до {maxWeight:F2} кг." +
                               $"\nВам нужно {option} вес от {Math.Abs(minWeight - weight):F2} до {Math.Abs(maxWeight - weight):F2} кг.";
            
            if (result <= 16)
            {
                resultStr = $"Выраженный дефицит массы тела." + diagnosis;
            }
            else if(result > 16 && result <= 18.5)
            {
                resultStr = "Недостаточная (дефицит) масса тела." + diagnosis;
            }
            else if (result > 18.5 && result <= 25)
            {
                resultStr = "Норма";
            }
            else if (result > 25 && result <= 30)
            {
                resultStr = "Избыточная масса тела (предожирение)." + diagnosis;
            }
            else if (result > 30 && result <= 35)
            {
                resultStr = "Ожирение 1 степени." + diagnosis;
            }
            else if (result > 35 && result <= 40)
            {
                resultStr = "Ожирение 2 степени." + diagnosis;
            }
            else if (result > 40)
            {
                resultStr = "Ожирение 3 степени." + diagnosis;
            }
            else
            {
                resultStr = "Возможно ошибочное значение.";
            }

            return resultStr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисляет индекс массы тела и определяет действия для нормализации параметра.");
            Console.Write("Введите массу тела в кг: ");

            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост в см: ");

            double height = Convert.ToDouble(Console.ReadLine());
            string result = MassBodyIndex(weight, height);

            Console.WriteLine("\nДиагноз:\n" + result);

        }
    }
}
