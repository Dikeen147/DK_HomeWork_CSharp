using System;

namespace W8_T5_ConvertCSVtoXML
{
    [Serializable]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public string City { get; set; }

        public Student() { }

        public Student(string firstName,
                        string lastName,
                        string university,
                        string faculty,
                        string department,
                        int age,
                        int course,
                        int group,
                        string city)
        {
            FirstName = firstName;
            LastName = lastName;
            University = university;
            Faculty = faculty;
            Department = department;
            Age = age;
            Course = course;
            Group = group;
            City = city;
        }
    }
    //class Student
    //{
    //    public string firstName;
    //    public string lastName;
    //    public string university;
    //    public string faculty;
    //    public string department;
    //    public int age;
    //    public int course;
    //    public int group;
    //    public string city;

    //    public Student(string firstName, string lastName, string university, string faculty,
    //        string department, int age, int course, int group, string city)
    //    {
    //        this.firstName = firstName;
    //        this.lastName = lastName;
    //        this.university = university;
    //        this.faculty = faculty;
    //        this.department = department;
    //        this.age = age;
    //        this.course = course;
    //        this.group = group;
    //        this.city = city;
    //    }
    //}
}
