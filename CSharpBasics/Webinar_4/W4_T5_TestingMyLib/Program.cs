﻿using System;
using MyLib;

namespace W4_T5_TestingMyLib
{
    /*
     Работа Долгова Константина

    Вебинар 4. Задача 5.
    *а) Реализовать библиотеку с классом для работы с двумерным массивом. 
    Реализовать конструктор, заполняющий массив случайными числами. Создать методы, 
    которые возвращают сумму всех элементов массива, сумму всех элементов массива 
    больше заданного, свойство, возвращающее минимальный элемент массива, свойство, 
    возвращающее максимальный элемент массива, метод, возвращающий номер максимального 
    элемента массива (через параметры, используя модификатор ref или out).
    *б) Добавить конструктор и методы, которые загружают данные из файла и записывают 
    данные в файл.
    **в) Обработать возможные исключительные ситуации при работе с файлами.

     */
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса работы с двумерными массивами
            MyTwoDimArray tda = new MyTwoDimArray(new int[4, 6], 0, 10);

            // Выводим полученный массив с случайными числами на экран
            tda.ShowTwoDimArr();
            Console.WriteLine("Сумма: " + tda.ArrayItemSum());
            Console.WriteLine($"Минимальный элемент: {tda.GetMinValue}");
            Console.WriteLine($"Максимальный элемент: {tda.GetMaxValue}");

            int maxValueIndex = 0;

            // Получение индекса максимального числа по ссылке
            tda.MaxValueIndex(ref maxValueIndex);
            Console.WriteLine($"Индекс мак. знач: " + maxValueIndex);

            string filePath = "../../../array.txt";

            // Сохраняем полученный двумерный массив случайных чисел в файл
            tda.SaveArrayInFile(filePath);

            // Загружаем данные двумерного массива из файла
            tda.LoadArrayFromFile(filePath);

            // Выводим данные массива на экран
            tda.ShowTwoDimArr();
        }
    }
}
