namespace CSharpCourse;

public class Student2: Person2
{
    public string Class { get; set; }

    public Student2(string name, string surname, string @class) : base(name, surname)
    {
        Class = @class;
    }

    public override void Salute()
    {
        AnsiConsole.WriteLine($"Hi I'm student {Name} {Surname}");
    }
}