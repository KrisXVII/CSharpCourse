namespace CSharpCourse;

public class Person2
{
    protected string Name { get; set; }
    protected string Surname { get; set; }

    public Person2(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public virtual void Salute()
    {
        AnsiConsole.WriteLine($"Hi dude I'm {Name} {Surname}");
    }
    
    public string StringSalute()
    {
        return $"Hi dude I'm {Name} {Surname}";
    }

    private void Cook() // accessible only in the class where it is defined, must encapsulate if needed elsewhere
    {
        AnsiConsole.WriteLine("Let me cook");
    }

    protected void Protect() // accessible only from the class where it is defined or child classes
    {
        AnsiConsole.WriteLine("Protected method");
    }

    internal void InternalMethod() // like public but not in another assembly
    {
        AnsiConsole.WriteLine("Internal method");
    }
    
}