using System;

namespace TempConverter
{
    class Program
    {
        private const string V = " is the Celcius equivalent";

        static void Main()
        {

            while (true)
            {
                Console.Write("Enter the temp in Fahrenheit: ");
                
                var entry = Console.ReadLine();

                if(entry.ToLower() == "quit")
                {
                    break;
                }
                try
                {
                    var tempToConvert = double.Parse(entry);
                    var convertedTemp = (tempToConvert - 32) * 5 / 9;

                    if(tempToConvert <= 0)
                    {
                        Console.WriteLine(tempToConvert + " is not a valid temperature!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(convertedTemp) + V);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid entry");
                    continue;
                }
            }
        }
    }
}
