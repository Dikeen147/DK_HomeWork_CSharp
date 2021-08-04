using System;

namespace W3_T3_Fraction
{
    /*
         Работа Долгова Константина

        Задача 3.
        Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
        Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
        демонстрирующую все разработанные элементы класса.
        
        * Добавить свойства типа int для доступа к числителю и знаменателю;
        * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        ** Добавить проверку, чтобы знаменатель не равнялся 0. 
           Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        *** Добавить упрощение дробей.
         */
    class Fraction
    {
        public int Numerator { get; set; }      // числитель
        public int Denominator { get; set; }    // знаменатель
        public double Division { get; set; }    // произведение чисел
        
        public Fraction()
        {
            this.Numerator = 1;
            this.Denominator = 1;
            this.Division = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Знаменатель не может быть равен 0!");

            this.Numerator = numerator;
            this.Denominator = denominator;

            this.Division = this.Numerator / (double)this.Denominator;
        }
        public string ShowNumbers()
        {
            return $"{this.Numerator} / {this.Denominator}";
        }
        public string GetProcuctOfNumbers()
        {
            return $"{this.Numerator} / {this.Denominator} = {(this.Division):F2}";
        }
        public void Reduce()
        {
            int nod = Nod();

            this.Numerator /= nod;
            this.Denominator /= nod;
        }
        public int Nod()
        {
            int n = Math.Abs(this.Numerator);
            int d = Math.Abs(this.Denominator);

            while (n != d)
            {
                if (n > d)
                    n = n - d;
                else
                    d = d - n;
            }

            return n;
        }
        public Fraction Plus(Fraction number)
        {
            return new Fraction(this.Numerator * number.Denominator + number.Numerator * this.Denominator, this.Denominator * number.Denominator);
        }
        public Fraction Minus(Fraction number)
        {
            return new Fraction(this.Numerator * number.Denominator - number.Numerator * this.Denominator, this.Denominator * number.Denominator);
        }
        public Fraction Multi(Fraction number)
        {
            return new Fraction(this.Numerator * number.Numerator, this.Denominator * number.Denominator);
        }
        public Fraction Div(Fraction number)
        {
            return new Fraction(this.Numerator * number.Denominator, this.Denominator * number.Numerator);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Дроби.\n");

            Fraction rn1 = new Fraction(3, 15);
            Fraction rn2 = new Fraction(24, 36);
            Fraction rn3 = rn1.Plus(rn2);

            Console.WriteLine("Сложение:\n" + rn3.ShowNumbers());
            rn3.Reduce();
            Console.WriteLine("Упрощение дробей: " + rn3.ShowNumbers() + "\nДесятичная дробь: " + rn3.GetProcuctOfNumbers());

            rn3 = rn1.Minus(rn2);
            Console.WriteLine("\nВычитание:\n" + rn3.ShowNumbers());
            rn3.Reduce();
            Console.WriteLine("Упрощение дробей: " + rn3.ShowNumbers() + "\nДесятичная дробь: " + rn3.GetProcuctOfNumbers());

            rn3 = rn1.Multi(rn2);
            Console.WriteLine("\nУмножение:\n" + rn3.ShowNumbers());
            rn3.Reduce();
            Console.WriteLine("Упрощение дробей: " + rn3.ShowNumbers() + "\nДесятичная дробь: " + rn3.GetProcuctOfNumbers());

            rn3 = rn1.Div(rn2);
            Console.WriteLine("\nДеление:\n" + rn3.ShowNumbers());
            rn3.Reduce();
            Console.WriteLine("Упрощение дробей: " + rn3.ShowNumbers() + "\nДесятичная дробь: " + rn3.GetProcuctOfNumbers());
        }
    }
}
