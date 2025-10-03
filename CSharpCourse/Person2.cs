namespace CSharpCourse;

public class Person2
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person2(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public virtual void Salute()
    {
        AnsiConsole.WriteLine($"Hi dude I'm {Name} {Surname}");
    }
    
}