using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples are grouped values added in C# 7
            (int a, int b) tup1 = (10, 20);
            var tup2 = ("Some text X", 10.5f);
            Console.WriteLine($" Before - tup1 is: {tup1}\n  and tup2 is: {tup2}");

            // TODO: Tuple values are mutable
            tup1.a *= 3;
            tup2.Item1 = "Text got changed";
            Console.WriteLine($"\n After  - tup1 is: {tup1}\n  and tup2 is: {tup2}");

            // TODO: Functions can work with tuples
            (int, int) result = PlusTimes(1, 3);
            Console.WriteLine("\nplus is: {0}, times is: {1}", result.Item1, result.Item2);
            Console.WriteLine($"result is: {result}");

        }

        // TODO: Functions can return multiple values using tuples
        static (int, int) PlusTimes(int a, int b) {
            return (a + b, a * b);
        }
    }
}
