using PersonLibrary;
namespace PersonLibrary.test;

public class Tests
{
    [Test]
    public void BMI_Test()
    {
        var person = new Person(default, default, default, default, default, default, default, default)
        {
            Weight = 70,
            Height = 1.75
        };
        Assert.That(person.CalculateBMI(), Is.EqualTo(22.86).Within(0.01));
    }
}