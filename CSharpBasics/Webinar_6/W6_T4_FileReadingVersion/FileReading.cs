using System;
using System.IO;

namespace W6_T4_FileReadingVersion
{
    class FileReading
    {
        public byte[] MethodFileStream(string fileName)
        {
            byte[] arr = null;

            try
            {
                FileStream fileIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                int i;
                int index = 0;
                arr = new byte[fileIn.Length];

                while ((i = fileIn.ReadByte()) != -1)
                {
                    arr[index] = (byte)i;
                    index++;
                }

                fileIn.Close();
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Error! File is not opened!");
                Console.WriteLine(ex.Message);
            }

            return arr;
        }

        public string MethodStreamReader(string fileName)
        {
            string result = String.Empty;
            try
            {
                StreamReader fileIn = new StreamReader(fileName);
                result = fileIn.ReadToEnd();

                fileIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! File {fileName} is not opened!");
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public int[] MethodBinaryReader(string fileName)
        {
            int[] arr = null;

            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader fileIn = new BinaryReader(fs);

                int index = 0;
                arr = new int[fs.Length];

                for (int i = 0; i < fs.Length; i++)
                {
                    arr[index] = fileIn.Read();
                    index++;
                }
                fs.Close();
                fileIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! File {fileName} is not opened.");
                Console.WriteLine(ex.Message);
            }

            return arr;
        }
    }
}
