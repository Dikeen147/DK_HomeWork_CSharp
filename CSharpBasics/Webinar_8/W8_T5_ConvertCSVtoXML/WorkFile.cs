using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace W8_T5_ConvertCSVtoXML
{
    class WorkFile
    {
        private Random rnd;
        private GenerateName gn;
        private List<Student> studentList;

        public WorkFile()
        {
            rnd = new Random();
            studentList = new List<Student>();
            gn = new GenerateName(LoadNames("Woman_names.txt"), LoadNames("Man_names.txt"), LoadNames("Last_names.txt"));
        }
        public List<string> LoadNames(string fileName)
        {
            var separator = new char[] { ' ', '\0', '\r', '\n' };
            return File.ReadAllText(fileName)
                                    .Split(separator)
                                    .Where(el => el.Length > 1 && !IsNumber(el))
                                    .ToList();
        }
        public bool IsNumber(string str) => double.TryParse(str, out double result);

        public Student CreateStudent()
        {
            const int COURSE = 6;
            const int MIN_AGE = 7;
            const int MAX_AGE = 100;
            const int GROUP_NUMBER_MIN = 1000;
            const int GROUP_NUMBER_MAX = 5000;

            string[] city = { "Чебоксары", "Москва", "Санкт-Петербург", "Казань", "Нижний Новгород", "Самара", "Тамбов",
                            "Иваново", "Мухасранск", "Кодиево", "Кадзимово" };
            string[] university = { "ЧГУ", "МГУ", "СПГУ", "ГГУ", "ЛГУ", "ИГУ", "НАТО", "НГИИ", "МГИМО", "МУХА", "КОД" };
            string[] faculty = { "Исскуств", "Инновационных технологий", "Здравых смыслов", "Многоликих", "Умных людей",
                            "Не оцень умных людей", "Просто по фану", "Каток в кс", "Геймеров", "Программеров", "Кодеров" };
            string[] department = { "Качества", "Проверки", "Инспекции", "Закупки", "Аналитики", "Бухгалтерии", "Самореализации",
                            "Деградирования", "WASD", "Пальценажимания", "Клонирования", "Домосидения" };

            string[] LastFirstName = gn.LastFirstName().Split(' ');

            return new Student
            {
                FirstName = LastFirstName[1],
                LastName = LastFirstName[0],
                University = university[rnd.Next(university.Length)],
                Faculty = faculty[rnd.Next(faculty.Length)],
                Department = department[rnd.Next(department.Length)],
                Age = rnd.Next(MIN_AGE, MAX_AGE),
                Course = rnd.Next(1, COURSE),
                Group = rnd.Next(GROUP_NUMBER_MIN, GROUP_NUMBER_MAX),
                City = city[rnd.Next(city.Length)]
            };
        }

        public void CreateStudentList(int count)
        {
            for (int i = 0; i < count; i++)
            {
                studentList.Add(CreateStudent());
            } 
        }

        public void SaveToCSV(string fileName)
        {
            List<string> list = new List<string>();

            foreach (var item in studentList)
            {
                string text = $"{item.FirstName};" +
                                $"{item.LastName};" +
                                $"{item.University};" +
                                $"{item.Faculty};" +
                                $"{item.Department};" +
                                $"{item.Age};" +
                                $"{item.Course};" +
                                $"{item.Group};" +
                                $"{item.City};";

                list.Add(text);    
            }

            File.WriteAllLines(fileName, list, Encoding.UTF8);
        }
        public void LoadFromCSV(string fileName)
        {
            var list = File.ReadAllLines(fileName).ToList();
            studentList.Clear();
            foreach (var item in list)
            {
                var line = item.Split(';');

                studentList.Add(new Student { 
                    FirstName = line[0],
                    LastName = line[1],
                    University = line[2],
                    Faculty = line[3],
                    Department = line[4],
                    Age = int.Parse(line[5]),
                    Course = int.Parse(line[6]),
                    Group = int.Parse(line[7]),
                    City = line[8]
                });
            }
        }
        public void SaveToXML(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            xmlFormat.Serialize(fStream, studentList);
            fStream.Close();
        }
        public void LoadFromXML(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            studentList = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public void ShowStudents()
        {
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName}, возраст: {item.Age} город {item.City}");
            }
        }

        public void ConvertCSVtoXML(string CSV_FileName, string XML_fileName)
        {
            LoadFromCSV(CSV_FileName);
            SaveToXML(XML_fileName);
        }
    }
}
