using System;

namespace Task_1_structComplex
{
    /*
     Работа Долгова Константина

    задача 1.
    а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    в) Добавить диалог с использованием switch демонстрирующий работу класса.
     */
    struct structComplex
    {
        public double im;
        public double re;

        public structComplex Plus(structComplex x)
        {
            structComplex y;
            y.im = this.im + x.im;
            y.re = this.re + x.re;

            return y;
        }
        public structComplex Minus(structComplex x)
        {
            structComplex y;
            y.im = this.im - x.im;
            y.re = this.re - x.re;

            return y;
        }
        public structComplex Multi(structComplex x)
        {
            structComplex y;
            y.im = this.re * x.im + this.im * x.re;
            y.re = this.re * x.re - this.im * x.im;

            return y;
        }
        public string toString()
        {
            return re + " + " + im + "i";
        }
    }
    class classComplex
    {
        private double im;
        private double re;

        public classComplex()
        {
            im = 0;
            re = 0;
        }
        public classComplex(double _im, double _re)
        {
            this.im = _im;
            this.re = _re;
        }
        public classComplex Plus(classComplex x)
        {
            classComplex y = new classComplex();
            y.im = this.im + x.im;
            y.re = this.re + x.re;

            return y;
        }
        public classComplex Minus(classComplex x)
        {
            classComplex y = new classComplex();
            y.im = this.im - x.im;
            y.re = this.re - x.re;

            return y;
        }
        public classComplex Multi(classComplex x)
        {
            classComplex y = new classComplex();
            y.im = this.re * x.im + this.im * x.re;
            y.re = this.re * x.re - this.im * x.im;

            return y;
        }
        public string ToString()
        {
            return re + " + " + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Комплексные числа (структура):");
            structComplex complex1;
            complex1.im = 1;
            complex1.re = 1;

            structComplex complex2;
            complex2.im = 2;
            complex2.re = 2;

            structComplex result = complex1.Plus(complex2);
            Console.WriteLine("Plus: " + result.toString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Minus: " + result.toString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Multi: " + result.toString());

            Console.WriteLine("\nКомплексные числа (класс):");
            classComplex complex3 = new classComplex(1, 1);
            classComplex complex4 = new classComplex(2, 2);
            classComplex classResult = complex3.Plus(complex4);
            Console.WriteLine("Plus: " + classResult.ToString());
            classResult = complex3.Minus(complex4);
            Console.WriteLine("Minus: " + classResult.ToString());
            classResult = complex3.Multi(complex4);
            Console.WriteLine("Multi: " + classResult.ToString());

            Console.WriteLine("/nВведите первое число Re: ");
            double re1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число Im: ");
            double im1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число Re: ");
            double re2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число Im: ");
            double im2 = int.Parse(Console.ReadLine());

            classComplex complex5 = new classComplex(im1, re1);
            classComplex complex6 = new classComplex(im2, re2);
            classComplex result3;
            int option;

            do
            {
                Console.WriteLine("Выберите действие: 1 - Plus, 2 - Minus, 3 - Multi, 4 - for Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        result3 = complex5.Plus(complex6);
                        Console.WriteLine("Plus: " + result3.ToString());
                        break;
                    case 2:
                        result3 = complex5.Minus(complex6);
                        Console.WriteLine("Minus: " + result3.ToString());
                        break;
                    case 3:
                        result3 = complex5.Multi(complex6);
                        Console.WriteLine("Multi: " + result3.ToString());
                        break;
                    case 4:
                        Console.WriteLine("Выход");
                        break;
                    default:
                        Console.WriteLine("Entered wrong option!");
                        break;
                }
            } while (option != 4);   
        }
    }
}
