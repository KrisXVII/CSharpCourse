using System.Collections;
using Spectre.Console;

namespace CSharpCourse
{
    class Beninging
    {
        private static void Main(string[] args)
        {
            string alpaca;
            alpaca = "alpaca";
            var sas = 8;
            var num1 = 5;
            var num2 = 10;
            var sum = num1 + num2;
            // AnsiConsole.WriteLine(sum);
            const int num = 12;
            // AnsiConsole.WriteLine($"{alpaca} {sas}");
            // AnsiConsole.WriteLine(sas + num);
            // AnsiConsole.WriteLine("Ini thi beninging");
            // AnsiConsole.WriteLine(Sum(1.2, 3));
            // Console.Read(); // doesn't end the process after execution

            var array = new ArrayList();
            array.Add("ossas");

            foreach (object item in array)
            {
                // AnsiConsole.WriteLine(item.ToString());
            }

            var list = new List<int>();
            list.Add(5);
            list.Add(8);
            list.Insert(0, 6);

            foreach (var number in list)
            {
                // AnsiConsole.WriteLine(number);
            }

            var hash = new Hashtable() { { "first", "value" }, { "second", "sebring" } };

            foreach (var entry in hash)
            {
                // AnsiConsole.WriteLine(entry.ToString());
            }

            var dude = new Person("Giorgio", 24);
            dude.Print();
            
            string greeting = dude.Greet();
            AnsiConsole.WriteLine(greeting);
            Console.WriteLine(Person.numeroPersone);

        }

        private static double Sum(double x, int y)
        {
            return x + y;
        }

    }
}