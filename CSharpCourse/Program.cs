
using System; // not necessary
using Spectre.Console;

namespace CSharpCourse
{
    class Beninging
    { 
        private static void Main(string[] args)
        {
            string alpaca;
            alpaca = "alpaca";
            int sas = 8;
            const int constant = 12;
            Console.WriteLine($"{alpaca} {sas}");
            Console.WriteLine(sas + constant);
            AnsiConsole.WriteLine("Ini thi beninging");
            // Console.Read(); // doesn't end the process after execution
        }
    }
}