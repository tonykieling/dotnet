using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            // TODO: if-else 
            // if (theVal == 50) {
            //     Console.WriteLine("theVal is equal to 50");
            // } else if (theVal > 50) Console.WriteLine("theVal is greater than 50");
            // else Console.WriteLine("it's something else");


            // -----------------------
            // TODO: Using the ternary operator ?:
            Console.WriteLine(" theVal is " + ((theVal > 10) ? "POSITIVE" : "NEGATIVE"));


            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: can be replaced by a ternary operator ?:

        }
    }
}
