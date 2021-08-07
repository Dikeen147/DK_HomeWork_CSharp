using System;
using System.Collections.Generic;
using System.IO;

namespace MyLib
{
    public class MyTwoDimArray
    {
        int[,] array;
        Random rnd = new Random();
        /// <summary>
        /// Конструктор задающий случайные числа двумерному массиву от min до max значения
        /// </summary>
        /// <param name="array"> Двумерный массив </param>
        /// <param name="minValue"> Минимальное случайное число </param>
        /// <param name="maxValue"> Максимальное случайное число </param>
        public MyTwoDimArray(int[,] array, int minValue, int maxValue)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.GetUpperBound(1) + 1;
            this.array = new int[rows, cols];
            
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    this.array[y, x] = rnd.Next(minValue, maxValue + 1);
                }
            }
        }
        /// <summary>
        /// Загрузка двумерного массива из файла
        /// </summary>
        /// <param name="filePath"> Путь до файла </param>
        public MyTwoDimArray(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    List<string[]> list = new List<string[]>();

                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line.Split(" "));
                    }

                    int rows = list.Count;
                    int cols = list[0].Length;
                    this.array = new int[rows, cols];

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            this.array[i, j] = int.Parse(list[i][j]);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Загрузка данных двумерного массива из файла
        /// </summary>
        /// <param name="filePath"> путь до загружаемого файла </param>
        public void LoadArrayFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    List<string[]> list = new List<string[]>();

                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line.Split(" "));
                    }

                    int rows = list.Count;
                    int cols = list[0].Length;
                    this.array = new int[rows, cols];

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            this.array[i, j] = int.Parse(list[i][j]);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Запсь данных двумерного массива в файл.
        /// </summary>
        /// <param name="filePath"> путь к записываемому файлу </param>
        public void SaveArrayInFile(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    Console.WriteLine($"Файл {filePath} найден.");
                    for (int i = 0; i < this.array.GetUpperBound(0) + 1; i++)
                    {
                        string line = String.Empty;

                        for (int j = 0; j < this.array.GetUpperBound(1) + 1; j++)
                        {
                            string space = j == this.array.GetUpperBound(1) ? "" : " ";
                            
                            line += this.array[i, j] + space;
                        }
                        sw.WriteLine(line);
                    }
                    sw.Close();
                    Console.WriteLine("Запись выполнена!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Метод возвращает сумму элементов двумерного массива
        /// </summary>
        /// <returns>Сумма элементов (int)</returns>
        public int ArrayItemSum()
        {
            int sum = 0;

            foreach (int item in this.array)
            {
                sum += item;
            }

            return sum;
        }
        /// <summary>
        /// Метод возвращает сумму элементов двумерного массива, больше заданного числа
        /// </summary>
        /// <param name="number"> Число, большие которого включаются в сумму</param>
        /// <returns> Сумма элементов (int) </returns>
        public int ArrayItemSum(int number)
        {
            int sum = 0;

            foreach (int item in this.array)
            {
                if (item > number)
                {
                    sum += item;        
                }
            }

            return sum;
        }
        /// <summary>
        /// Метод возвращающий индекс максимального значения массива, по ссылке
        /// </summary>
        /// <returns> Индекс максимального значения двумерного массива </returns>
        public int MaxValueIndex(ref int maxValueIndex)
        {
            int max = GetMaxValue;
            maxValueIndex = 0;

            foreach (int item in this.array)
            {
                if (item == max) break;
                maxValueIndex++;
            }

            return maxValueIndex;
        }
        /// <summary>
        /// Преобразование двумерного массива в одномерный и его сортировка
        /// </summary>
        /// <returns> Отсортированный одномерный массив </returns>
        private int[] SortedOneDimArray()
        {
            int[] mas = new int[this.array.Length];
            int index = 0;

            foreach (int item in this.array)
            {
                mas[index] = item;
                index++;
            }
            Array.Sort(mas);

            return mas;
        }
        /// <summary>
        /// Минимальный элемент массива
        /// </summary>
        public int GetMinValue
        {
            get
            {
                return SortedOneDimArray()[0];
            }
        }
        /// <summary>
        /// Максимальный элемент массива
        /// </summary>
        public int GetMaxValue
        {
            get
            {
                int[] mas = SortedOneDimArray();

                return mas[mas.Length - 1];
            }
        }
        /// <summary>
        /// Вывод двумерного массива в консоль
        /// </summary>
        /// <param name="array"> Двумерный массив </param>
        public void ShowTwoDimArr()
        {
            int rows = this.array.GetUpperBound(0) + 1;
            int cols = this.array.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{this.array[i, j], 3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
