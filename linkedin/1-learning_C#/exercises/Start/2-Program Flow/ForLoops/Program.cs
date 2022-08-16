using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog O";
            // string str = "TesT";

            // TODO: the basic for loop
            // Console.WriteLine("The basic for loop:");
            // for (int i = 0; i < myVal; i++) {
            //     Console.WriteLine("current i is: {0}", i);
            // }


            // Console.WriteLine();

            // TODO: the foreach-in loop can be used to iterate over sequences
            // Console.WriteLine("The foreach loop:");
            // Console.WriteLine("nums array: " + "[{0}]", string.Join(", ", nums));
            // foreach (int i in nums) {
            //     Console.WriteLine("   - i is {0}" + i);
            // }


            // TODO: count the number of o's in the string
            int count = 0;
            foreach (char c in str) {
                if (c == 'o' || c == 'O') count++;
            }
            Console.WriteLine(" letter o OR O appears {0} times", count);

        }
    }
}
