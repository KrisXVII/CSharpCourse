using CSharpCourse;

namespace CSharpCourse.Tests;

public class Person2Tests
{
    [Fact]
    public void Greet_ReturnsCorrectGreeting()
    {
        var person = new Person2("John", "Doe");
        var result = person.StringSalute();
        Assert.Equal($"Hi dude I'm John Doe", result);
    }
}
