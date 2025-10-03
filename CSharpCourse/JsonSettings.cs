namespace CSharpCourse;
using System.Text.Json;
using Spectre.Console;

public static class JsonHelper
{
    private static readonly JsonSerializerOptions PrettyOptions = new()
    {
        WriteIndented = true
    };

    public static string ToPrettyJson(this object obj)
    {
        return JsonSerializer.Serialize(obj, PrettyOptions);
    }

    public static void Print(this object obj)
    {
        AnsiConsole.WriteLine(ToPrettyJson(obj));
    }
}