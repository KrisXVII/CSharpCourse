namespace CSharpCourse;

public class Student: Person
{
    [JsonProperty(Order = 4)]
    public string Institute { get; set; }
    
    [JsonProperty(Order = 5)]
    public string Class { get; set; }
    
    public Student(
        string name,
        string surname,
        int age,
        string institute,
        string @class
        ) : base(name, surname, age)
    {
        Institute = institute;
        Class = @class;
    }

    public override string Greet()
    {
        return "Good morning";
    }
    
}