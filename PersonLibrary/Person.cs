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

        public Person(int age, string gender, double height, double weight, string nationality, string religion, string profession, string passportInfo)
        {
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            Nationality = nationality;
            Religion = religion;
            Profession = profession;
            PassportInfo = passportInfo;
        }

        // Метод для обчислення індексу маси тіла
        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
    }
}
