using System;
using System.ComponentModel.DataAnnotations;
using PersonLibrary;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(age:18, 
        gender: "male", 
        height: 1.70,
        weight:70,
        nationality: "german",
        religion: "atheist",
        profession: "none",
        passportInfo: "321***343",
        studentID: 56,
        group: "CH-12");

        Employee employee = new Employee(
            age: 35,
            height: 1.80,
            weight: 74,
            gender: "male",
            nationality:"spanish",
            religion:"christianity",
            profession:"lector",
            passportInfo:"343****321",
            department:"CH",
            position:"science proffesor"
        );
        
        Console.WriteLine($"Student: Age: {student.Age}, Gender: {student.Gender}, Height: {student.Height}, Weight: {student.Weight}, Nationality: {student.Nationality}, Religion: {student.Religion}, Profession: {student.Profession}, Passport Info: {student.PassportInfo}, Student ID: {student.StudentID}, Group: {student.Group}");
        double sBMI = student.CalculateBMI();
        Console.WriteLine($"Student BMI is: {sBMI}");
 
        Console.WriteLine($"Employee: Age: {employee.Age}, Gender: {employee.Gender}, Height: {employee.Height}, Weight: {employee.Weight}, Nationality: {employee.Nationality}, Religion: {employee.Religion}, Proffesion: {employee.Profession}, Passport Info: {employee.PassportInfo}, Department: {employee.Department}, Position: {employee.Position}");
        double eBMI = employee.CalculateBMI();
        Console.WriteLine($"Employee BMI is: {eBMI}");
    }
}
