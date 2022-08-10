using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // TODO: Output information using formatting
            Console.WriteLine($"The car is: {make} - {model} - {{{year}}} - {miles * 1.6:0} Km - {price:C2}");


            // TODO: Using string interpolation


            // TODO: With inline expressions

        }
    }
}
