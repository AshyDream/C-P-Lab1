namespace PersonLibrary
{
    public class Student : Person
    {
        // Властивості Студента
        public int StudentID { get; set; }
        public string Group { get; set; }

        // Конструктор для студента
        public Student(int age, string gender, double height, double weight, string nationality, string religion, string profession, string passportInfo, int studentID, string group)
            : base(age,gender,height,weight,nationality,religion,profession,passportInfo)
        {
            StudentID = studentID;
            Group = group;
        }
    }
}
