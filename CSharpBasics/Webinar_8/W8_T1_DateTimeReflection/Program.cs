using System;

namespace W8_T1_DateTimeReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new DateTime().GetType().GetProperties())
                Console.WriteLine($"{item,30} | {item.Name}");
        }
    }
}
