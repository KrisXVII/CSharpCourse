namespace CSharpCourse;

class CsTeacher: Teacher
{
    [JsonProperty(Order = 5)]
    public string PLanguage { get; set; }
    
    public CsTeacher(string name, string surname, int age, string subject, string pLanguage) : base(name, surname, age, subject)
    {
        PLanguage = pLanguage;
    }
}