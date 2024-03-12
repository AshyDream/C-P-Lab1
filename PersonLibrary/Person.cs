using System;

namespace PersonLibrary
{
    public class Person
    {
        // Властивості Людини
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Profession { get; set; }
        public string PassportInfo { get; set; }

        // Метод для обчислення індексу маси тіла
        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
    }

    public class Student : Person
    {
        // Властивості Студента
        public int StudentID { get; set; }
        public string Group { get; set; }

        // Конструктор для студента
        public Student(int age, string gender, double height, double weight, string nationality, string religion, string profession, string passportInfo, int studentID, string group)
        {
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            Nationality = nationality;
            Religion = religion;
            Profession = profession;
            PassportInfo = passportInfo;
            StudentID = studentID;
            Group = group;
        }
    }

    public class Employee : Person
    {
        // Властивості Працівника
        public string Department { get; set; }
        public string Position { get; set; }

        // Конструктор для працівника
        public Employee(int age, string gender, double height, double weight, string nationality, string religion, string profession, string passportInfo, string department, string position)
        {
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            Nationality = nationality;
            Religion = religion;
            Profession = profession;
            PassportInfo = passportInfo;
            Department = department;
            Position = position;
        }
    }
}
