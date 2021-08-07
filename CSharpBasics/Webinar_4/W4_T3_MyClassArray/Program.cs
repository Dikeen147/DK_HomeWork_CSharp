using System;

namespace ArrayClass
{
    /*
     Работа Долгова Константина

    Вебинар 4. Задача 3.
    а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, 
    создающий массив определенного размера и заполняющий массив числами от начального 
    значения с заданным шагом. Создать свойство Sum, которое возвращает сумму 
    элементов массива, метод Inverse, возвращающий новый массив с измененными знаками 
    у всех элементов массива (старый массив, остается без изменений),  метод Multi, 
    умножающий каждый элемент массива на определённое число, свойство MaxCount, 
    возвращающее количество максимальных элементов. 
    б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать 
    работу библиотеки
    в) *** Подсчитать частоту вхождения каждого элемента в массив 
    (коллекция Dictionary<int,int>)
     */
    class MyArray
    {
        int[] a;
        // Создание массива и заполнение его числами от начального значения с заданным шагом
        public MyArray(int arrayLength, int firstNum, int itemStep)
        {
            a = new int[arrayLength];
            a[0] = firstNum;

            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + itemStep;
            }
        }
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max, string s = null)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        // Метод возвращающий новый массив с измененными знаками
        public int[] Inverse()
        {
            int[] newArr = new int[this.a.Length];

            for (int i = 0; i < this.a.Length; i++)
            {
                newArr[i] = -this.a[i];
            }

            return newArr;
        }
        // Метод, умножающий элементы массива на определенное число
        public void Multi(int number)
        {
            for (int i = 0; i < this.a.Length; i++)
            {
                this.a[i] *= number;
            }
        }
        // Свойство, возвращающее сумму всех элеменетов массива
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int item in this.a)
                {
                    sum += item;
                }

                return sum;
            }
        }
        // Свойство, возвращающее количество максимальных элементов
        public int MaxCount
        {
            get
            {
                Array.Sort(this.a);
                int index = this.a.Length - 2;
                int maxValue = this.a[a.Length - 1];
                int maxValueCount = 1;

                while (this.a[index] == maxValue)
                {
                    maxValueCount++;
                }

                return maxValueCount;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса MyArray и задаем массив в 10 элементов, начиная с 1 и с шагом 5.
            MyArray array = new MyArray(10, 0, 5);
            Console.WriteLine("Массив:\n" + array.ToString());

            // Изменяем знаки массива в новый массив
            int[] inverseArr = array.Inverse();
            Console.WriteLine("\nМассив с измененными знаками:");
            for (int i = 0; i < inverseArr.Length; i++)
            {
                Console.Write(inverseArr[i] + " ");
            }
            // Умножаем элементы массива на 2
            array.Multi(2);
            Console.WriteLine("\n\nМассив эл * 2:\n" + array.ToString());

            // Сумма элементов массива
            Console.WriteLine("\nСумма элементов массива:\n" + array.Sum);

            // Максимальное значение
            Console.WriteLine("\nМаксимальное значение: " + array.Max);

            // Количество максимальных значений
            Console.WriteLine("\nКоличество максимальных значений: " + array.MaxCount);

        }
    }
}
