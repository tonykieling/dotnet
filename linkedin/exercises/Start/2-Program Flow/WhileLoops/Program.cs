using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";

            // TODO: basic while loop executes while the gate condition is true
            Console.WriteLine("Basic while() loop:");

            while(inputStr != "exit") {
                inputStr = Console.ReadLine();
                // if (inputStr == "exit") break;

                Console.WriteLine(" you entered: {0}", inputStr);
            }

            // Console.WriteLine("byyye");

            // TODO: the do-while loop always executes at least one time
            // Console.WriteLine("The  do-while() loop:");
            // do {
            //     Console.WriteLine(" \ntype something: ");
            //     inputStr = Console.ReadLine();
            //     Console.WriteLine(" you entered {0}", inputStr );
            // } while (inputStr != "exit");
            // Console.WriteLine(" CY");
        }
    }
}
