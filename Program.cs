using System;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           var celsius =  TempConverter.FahrenheitToCelsius(75);
            Console.WriteLine($"fahrenheit to celcius is: {celsius}\n");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(18);
            Console.WriteLine($"celsius to fahrenheit is: {fahrenheit}\n");
        }
    }
}
