using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_T2_StaticClassMessage
{
    /*
     Работа Долгова Константина
    
    Вебинар 5. Задача 2.
    Разработать статический класс Message, содержащий следующие статические методы 
    для обработки текста:
    а) Вывести только те слова сообщения,  которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    д) ***Создать метод, который производит частотный анализ текста. В качестве 
    параметра в него передается массив слов и текст, в качестве результата метод 
    возвращает сколько раз каждое из слов массива входит в этот текст. Здесь 
    требуется использовать класс Dictionary.
     */
    public static class Message
    {
        /// <summary>
        /// Метод анализирует текст и записывает в частотный массив, сколько раз повторяются указанные слова
        /// </summary>
        /// <param name="words"> Список слов для поиска в тексте </param>
        /// <param name="text"> Исходный текст </param>
        /// <returns> Частотный массив с количеством вхождений каждого слова в текст </returns>
        public static Dictionary<string, int> TextFreqAnalis(string[] words, string text)
        {
            char[] separator = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
            Dictionary<string, int> list = new Dictionary<string, int>();
            List<string> textWords = text.ToLower().Split(separator).Where(w => w != "").ToList();

            foreach (var item in words)
                list.Add(item, 0);

            for (int i = 0; i < words.Length; i++)
            {
                foreach (var item in textWords)
                {
                    if (words[i].CompareTo(item) == 0)
                    {
                        list[words[i]]++;
                    }
                }
            }
            
            return list;
        }
        /// <summary>
        /// Метод возвращает список строк, слова которого не больше указанного значения
        /// </summary>
        /// <param name="line"> Исходная строка </param>
        /// <param name="n"> Максимлаьная длина слова </param>
        /// <returns></returns>
        public static List<string> GetNSymbolWords(string line, int n)
        {
            char[] separator = new char[] { ' ', ',', '.' };
            var arr = line.Trim().Split(separator).Where(el => el != "").ToList();
            List<string> words = new List<string>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Length <= n)
                {
                    //Console.WriteLine(arr[i]);
                    words.Add(arr[i]);
                }
            }
            return words;
        }
        /// <summary>
        /// Метод удаляет из строки слово, последний элемент которого равен указанному.
        /// </summary>
        /// <param name="line"> Исходная строка </param>
        /// <param name="c"> Послдедний элемент слова </param>
        /// <returns></returns>
        public static string DelWordByWordEndSymbol(string line, char c)
        {
            var arr = line.Trim().Split(' ').Where(el => el != "").ToList();
            var newArr = arr.Where(el => (el[el.Length - 1] == c 
                    || (el[el.Length - 1] == ',' && el[el.Length - 2] == c)
                    || (el[el.Length - 1] == '.' && el[el.Length - 2] == c))).ToList();

            foreach (var item in newArr)
                line = line.Replace(item, "");

            return line;
        }
        /// <summary>
        /// Метод возвращающий самые длинные слова из строки
        /// </summary>
        /// <param name="line"> Исходная строка </param>
        /// <returns> Список с длинными словами </returns>
        public static List<string> MaxLenWords(string line)
        {
            List<string> maxLenWords = new List<string>();
            char[] separator = { ' ', ',', '.' };
            var arr = line.Trim().Split(separator).Where(el => el != "").ToList();
            var lenArr = arr.Select(el => el.Length).ToList();

            lenArr.Sort();

            int maxLenWord = lenArr[lenArr.Count - 1];

            foreach (var item in arr)
                if (item.Length == maxLenWord) maxLenWords.Add(item);

            return maxLenWords;
        }
        /// <summary>
        /// Метод создающий строку из самых длинных слов исходной строки
        /// </summary>
        /// <param name="line"> Исходная строка </param>
        /// <returns> Строка из самых длинных слов </returns>
        public static string MaxWordsLine(string line)
        {
            List<string> maxLenWords = MaxLenWords(line);
            StringBuilder sb = new StringBuilder();

            foreach (var item in maxLenWords)
                sb.Append(item + " ");

            return sb.ToString().TrimEnd();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходная строка:");
            string str = " Hello, World!  EveryBody this,  ManGo  is nice  colparalo baby colorado 123 aso.  ";
            Console.WriteLine(str);

            // Вывод слов из строки, в которых не более 4 символов
            Console.WriteLine("\nСлова из строки не больше указанной длины:");
            foreach (var item in Message.GetNSymbolWords(str, 4))
                Console.WriteLine(item);

            // Удаление слов из строки, заканчивающиеся на символ o и вывод результирующей строки
            Console.WriteLine("\nРезультирующая строка:");
            Console.WriteLine(Message.DelWordByWordEndSymbol(str, 'o'));

            // Самые длинные слова в строке
            Console.WriteLine("\nСписок длинных слов:");
            foreach (var item in Message.MaxLenWords(str))
                Console.WriteLine(item);

            // Строка из длинных слов
            Console.WriteLine("\nСтрока из длинных слов:");
            Console.WriteLine(Message.MaxWordsLine(str));

            //
            Console.WriteLine("\nЧастотный анализ текста:");
            string text = "test testing asdag Test kasd test, asdkl asd asd asd Asd aSd asfef";
            var list = Message.TextFreqAnalis(new string[] { "test", "asd" }, text);
            Console.WriteLine($"Исходный текст:\n{text}");

            foreach (var item in list)
            {
                Console.WriteLine($"слово: {item.Key} в тексте встречается: {item.Value} раз");
            }
        }
    }
}
