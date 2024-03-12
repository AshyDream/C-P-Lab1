namespace PersonLibrary
{
    public class Employee : Person
    {
        // Властивості Працівника
        public string Department { get; set; }
        public string Position { get; set; }

        // Конструктор для працівника
        public Employee(int age, string gender, double height, double weight, string nationality, string religion, string profession, string passportInfo, string department, string position)
        : base( age,gender,height,weight,nationality,religion,profession,passportInfo)
        {
            Department = department;
            Position = position;
        }
    }
}
