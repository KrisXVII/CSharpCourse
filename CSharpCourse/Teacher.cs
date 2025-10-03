namespace CSharpCourse;
using Newtonsoft.Json;
class Teacher : Person
{
    [JsonProperty(Order = 4)]
    public string Subject { get; private set; }

    public Teacher(string name, string surname, int age, string subject) : base(name, surname, age)
    {
        Subject = subject;
    }

    public sealed override string Greet() // sealed does not allow CsTeacher class to override Greet()
    {
        return $"- Hi students, today we keep up with {Subject}, are you ready?";
    }
}