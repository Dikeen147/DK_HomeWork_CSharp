using System;

namespace MyLib
{
    public static class MyMethods
    {
        /// <summary>
        /// Output of a message at the specified coordinates
        /// </summary>
        /// <param name="msg"> Messages </param>
        /// <param name="x"> The x coordinate of the cursor </param>
        /// <param name="y"> The y coordinate of the cursor </param>
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Displaying a message in the center of the screen
        /// </summary>
        /// <param name="msg"> Message </param>
        public static void PrintScreenCenter(string msg)
        {
            int x = Console.WindowWidth / 2 - msg.Length / 2;
            int y = Console.WindowHeight / 2;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Pause. Waiting for a key press
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Pause with the message output. Waiting for a key press
        /// </summary>
        /// <param name="msg"></param>
        public static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
