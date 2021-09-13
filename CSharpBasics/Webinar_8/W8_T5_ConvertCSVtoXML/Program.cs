using System;

namespace W8_T5_ConvertCSVtoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Student";
            WorkFile obj = new WorkFile();

            obj.CreateStudentList(5);
            obj.SaveToCSV($"{fileName}.csv");

            obj.ConvertCSVtoXML($"{fileName}.csv", $"{fileName}.xml");
        }
    }
}
