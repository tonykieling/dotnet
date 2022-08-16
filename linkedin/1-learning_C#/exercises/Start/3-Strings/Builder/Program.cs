using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ///
            // diff btw String and StringBuilder
            // https://www.youtube.com/watch?v=Br0mppS4d6A
            ///
            */

            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // TODO: create a StringBuilder
            StringBuilder sb = new StringBuilder("initial content", 100); 
                // --- second parameter is the maximum size of the new string
            
            // TODO: print some basic stats about the StringBuilder
            Console.WriteLine($"{sb}: {sb.Capacity} - {sb.Length}");


            // TODO: Add some strings to the builder using Append


            // TODO: AppendLine can append a line ending


            // TODO: AppendFormat can be used to append formatted strings


            // TODO: AppendJoin can iterate over a set of values


            // TODO: Modify the content using Replace


            // TODO: Insert content at any index

            
            // TODO: Convert to a single string

        }
    }
}
