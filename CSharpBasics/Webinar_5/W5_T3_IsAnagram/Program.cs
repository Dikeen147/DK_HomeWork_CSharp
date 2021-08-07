using System;

namespace W5_T3_IsAnagram
{
    /*
     Работа Долгова Константина

    Вебинар 5. Задача 3.
    *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    Например:
    badc являются перестановкой abcd.
     */
    class Program
    {
        /// <summary>
        /// Метод проверяющий является ли первая строка анаграммой второй строки
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length > str2.Length) return false;

            var charArr1 = str1.ToCharArray();
            var charArr2 = str2.ToCharArray();

            Array.Sort(charArr1);
            Array.Sort(charArr2);

            var s1 = String.Join('\0', charArr1);
            var s2 = String.Join('\0', charArr2);

            return s1.CompareTo(s2) == 0 ? true : false;
        }
        static void Main(string[] args)
        {
            string str1 = "abcd";
            string str2 = "bacd";

            Console.Write($"{str1} is anagram {str2} ? {IsAnagram(str1, str2)}\n");
            Console.ReadKey();
        }
    }
}
