using System;

namespace W6_T4_FileReadingVersion
{
    /*
     Работа Долгова Константина
     
     Вебинар 6. Задача 4.
     **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. 
     Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), 
     строку для StreamReader и массив int для BinaryReader.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "data.txt";
            FileReading fr = new FileReading();

            // Метод FileStream
            byte[] arr = fr.MethodFileStream(fileName);

            foreach (var item in arr)
                Console.Write(item + ", ");

            // Метод StramReader
            Console.WriteLine();
            string result = fr.MethodStreamReader(fileName);
            Console.WriteLine($"Result: {result}");

            // Метод BinaryReader
            Console.WriteLine();
            int[] arr2 = fr.MethodBinaryReader(fileName);
            foreach (var item in arr2)
                Console.Write(item + "_");
        }
    }
}
