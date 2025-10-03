namespace CSharpCourse;

public class Teacher3: Person2
{
    private string Subject { get; set; }

    public Teacher3(string name, string surname, string subject) : base(name, surname)
    {
        Subject = subject;
    }

    public override void Salute()
    {
        AnsiConsole.WriteLine($"Good morning people I am {Name} {Surname}");
    } 
}