using System;
using System.IO;

namespace W4_T2_TaskOneInStaticClass
{
    /*
     Работа Долгова Константина

    Вебинар 4. Задача 2.
    Реализуйте задачу 1 в виде статического класса StaticClass;
    а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен 
    возвращать массив целых чисел;
    в)**Добавьте обработку ситуации отсутствия файла на диске.

     */
    static class ArrayPair
    {
        static int count;

        public static void SearchArrayPair(int[] arr)
        {
            Console.WriteLine("{0, 10}{1, 10}{2, 10}{3, 10}{4, 10}{5, 10}", 
                "Pair 1", "Number 1", "Bool 1", "Pair 2", "Number 2", "Bool 2");
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
            Console.WriteLine($"\nPair count = {count}");
        }
        public static int[] SearchPairFromFile()
        {
            string fileName = "array.txt";
            int[] arr = new int[20];
            int index = 0;

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        arr[index] = int.Parse(line);
                        index++;
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read!");
                Console.WriteLine(ex.Message);
            }

            return arr;
        }
        public static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10_000, 10_001);
            }
            Console.WriteLine("Пары массива, в которых только один делится на 3\n");
            ArrayPair.SearchArrayPair(arr);

            // Чтение массива из файла
            int[] arr2 = ArrayPair.SearchPairFromFile();

            Console.WriteLine("\nВывод массива из текстового файла\n");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + ", ");
            }
        }
    }
}
