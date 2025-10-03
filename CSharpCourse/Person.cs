namespace CSharpCourse;

public class Person
{
    public string Name { get; private set; } 
    public int Age { get; private set; }

    public static int numeroPersone;
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        numeroPersone++;
    }

    public string Greet()
    {
        return $"- Hey there {Name}, how old are you?\n" +
               $"- I'm {Age} years old";
    }
}
