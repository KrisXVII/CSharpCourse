namespace CSharpCourse;

public class Teacher2: IEquatable<Teacher2>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Subject { get; set; }

    public Teacher2(string name, string surname, string subject)
    {
        Name = name;
        Surname = surname;
        Subject = subject;
    }
    
    public bool Equals(Teacher2 teacher)
    {
        return Name == teacher.Name;
    }
}