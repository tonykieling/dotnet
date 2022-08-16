using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};

            Console.WriteLine("Using break and continue :");
            Console.WriteLine(" values array is [{0}]", String.Join(", ", values));
            Console.WriteLine($" values array is [{String.Join(", ", values)}]");

            foreach (int val in values)
            {
                // TODO: The continue statement skips the rest of the loop entirely
                // and jumps to the next iteration (if there is one)

                if (val > 40) {
                    Console.WriteLine(" {0} is greater than 40, so program is been ended ", val);
                    break;
                }
                // if (val > 19 && val < 30) {
                //     Console.WriteLine(" {0} is in the 20s, so lets skip it ", val);
                //     continue;
                // }
                // print the value
                Console.WriteLine($"val is currently {val}");

                // TODO: The break statement stops the loop and exits

            }
        }
    }
}
