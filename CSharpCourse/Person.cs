namespace CSharpCourse;

public class Person
{
    [JsonProperty(Order = 1)]
    public string Name { get; set; } 
    
    [JsonProperty(Order = 2)]
    public string Surname { get; set; }
    
    [JsonProperty(Order = 3)]
    public int Age { get; set; }
    
    public static int NumeroPersone;
    
    public Person(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
        NumeroPersone++;
    }

    public virtual string Greet()
    {
        return $"- Hey there {Name}, how old are you?\n" +
               $"- I'm {Age} years old";
    }
}
