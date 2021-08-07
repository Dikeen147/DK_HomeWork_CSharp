using System;

namespace W4_T1_FindPairDivThree
{
    class Program
    {
        /*
         Работа Долгова Константина

        Вебинар 4. Задача 1.
        Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  
        целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
        Написать программу, позволяющую найти и вывести количество пар элементов массива, 
        в которых только одно число делится на 3. В данной задаче под парой подразумевается 
        два подряд идущих элемента массива. Например, для массива из пяти элементов: 
        6; 2; 9; –3; 6 ответ — 2. 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Программа поиска пар в массиве.");

            int[] arr = new int[20];
            Random rnd = new Random();
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10_000, 10_001);
            }
            Console.WriteLine("Массив случайных чисел:");
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 10 == 0) Console.WriteLine();
                Console.Write($"{arr[i], 7}");
            }
            Console.WriteLine("\n\n{0, 10}{1, 10}{2, 10}{3, 10}{4, 10}{5, 10}", 
                "Pair 1", "Number 1", "Bool 1", "Pair 2", "Number 2", "Bool 2");
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) 
                    || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    count++;
                    Console.WriteLine("{0, 10}{1, 10}{2, 10}{3, 10}{4, 10}{5, 10}", 
                        $"arr[{i}]", arr[i], arr[i] % 3 == 0, $"arr[{i + 1}]", arr[i + 1], arr[i + 1] % 3 == 0);
                }
            }
            Console.WriteLine($"\nCount = {count}");
            Console.ReadKey();
        }
    }
}
