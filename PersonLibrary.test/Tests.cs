using PersonLibrary;
namespace PersonLibrary.test;

public class Tests
{
    [Test]
    public void TestBMI()
    {
        var person = new Person {
            Weight = 70,
            Height = 1.75
        };
        Assert.That(person.CalculateBMI(), Is.EqualTo(22.86).Within(0.01));
    }
}