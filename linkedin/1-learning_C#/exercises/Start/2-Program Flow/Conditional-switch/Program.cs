using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 52;

            // TODO: The switch statement
            switch(theVal) {
                case 40:
                    Console.WriteLine(" theVal is 40!");
                    break;
                case 50:
                    Console.WriteLine(" theVal is 50");
                    break;
                case 51:
                case 52:
                case 53:
                    Console.WriteLine(" theVal is in inital 50s");
                    break;
                default:
                    Console.WriteLine(" theVal is something else");
                    break;
            }

        }
    }
}
