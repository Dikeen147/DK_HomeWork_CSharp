using System;
using System.Collections.Generic;
using System.IO;

namespace W6_T2_DoubleBinary
{
    /*
     Работа Долгова Константина

    Вебинар 6. Задача 2.
    Модифицировать программу нахождения минимума функции так, 
    чтобы можно было передавать функцию в виде делегата. 
    а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции 
    и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором 
    хранятся различные функции.
    б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она 
    возвращает минимум через параметр (с использованием модификатора out). 
     */
    class DoubleBinary
    {
        public delegate double Fun(double x);
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Fx2(double x)
        {
            return x * x;
        }
        public static double Sin(double x)
        {
            return Math.Sin(x);
        }
        public static void SaveFunc(string fileName, Fun Func, double x, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            //double x = a;
            Console.WriteLine("SaveFunc:");
            while (x <= b)
            {
                bw.Write(Func(x));
                Console.WriteLine($"x: {x,5:0.0}, F(x): {Func(x),8:0.00}");
                x += h;
            }
            bw.Close();
            fs.Close();
            Console.WriteLine("SaveFunc succesful closed:");
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            Console.WriteLine("Load:");
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = br.ReadDouble();
                if (d < min) min = d;
            }
            br.Close();
            fs.Close();
            Console.WriteLine("Load succesful closed:");

            return min;
        }
        public static void StartDemo(string fileName)
        {
            Console.WriteLine("Выберите функцию: ");
            Console.WriteLine("1: F(x) => x * x - 50 * x + 10;" +
                            "\n2: Fx2(x) => x * x;" +
                            "\n3: Sin(x) => sin(x);");
            Fun function;
            var option = int.Parse(Console.ReadLine());

            Console.Write("Выберите промежуток значений:\nМинимальное значение: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Максимальное значение: ");
            int max = int.Parse(Console.ReadLine());

            Console.Write("Шаг вычислений: ");
            int step = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SaveFunc(fileName, F, min, max, step);
                    break;
                case 2:
                    SaveFunc(fileName, Fx2, min, max, step);
                    break;
                case 3:
                    SaveFunc(fileName, Sin, min, max, step);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Func min value: " + Load(fileName));
            Console.ReadKey();
        }
    }
}
