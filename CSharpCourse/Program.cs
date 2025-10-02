
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
            int num1 = 5, num2 = 10;
            int sum = num1 + num2;
            AnsiConsole.WriteLine(sum);
            const int num = 12;
            AnsiConsole.WriteLine($"{alpaca} {sas}");
            AnsiConsole.WriteLine(sas + num);
            AnsiConsole.WriteLine("Ini thi beninging");
            AnsiConsole.WriteLine(Sum(1.2, 3));
            // Console.Read(); // doesn't end the process after execution
        }

        private static double Sum(double x, int y)
        {
            return x + y;
        }
    }
}