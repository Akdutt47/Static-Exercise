using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(78);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(32);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
