using System;
// using String;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ///
            // https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0
            // https://www.geeksforgeeks.org/c-sharp-string-class/
            ///
            */

            // Declare some strings for the exercises
            string outstr = "";
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};

            // TODO: Length of a string 
            Console.WriteLine(str1.Length + " - " + strs.Length);

            // TODO: Access individual characters
            Console.WriteLine($" - {str1[0]}{str1[1]} and {strs[1]}");

            // TODO: iterate over a string like any other sequence of values
            // foreach( char c in str1 ) {
            //     Console.Write(c == 'b' ? "B" : c);
            // }
            // Console.WriteLine();
            // for (int i = 0; i < str1.Length; i++) {
            //     char temp = str1[i];
            //     Console.Write(temp == 'b' ? "B" : temp);
            // }

            // TODO: String Concatenation
            // outstr = String.Concat(strs);
            // string[] tempArray = str1.Split();
            // Console.WriteLine($" array: {String.Join(" ", tempArray)}");

            // for (int i = 0; i < tempArray.Length; i++)
            //     Console.WriteLine(tempArray[i]);

            // foreach ( string s in tempArray ) {
            //     // outstr += String.Concat(s);
            //     if (s.Length > 3) continue;
            //     outstr += ($"_{String.Concat(s)}");
            //     Console.Write($" -{outstr}");
            // }
            // Console.WriteLine();
            // Console.WriteLine(" = final: " + outstr);

            // TODO: Joining strings together with Join
            // outstr = "";
            // outstr = String.Join("---", strs);
            // Console.WriteLine(outstr);


            // TODO: String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            // Console.WriteLine(String.Compare("atony", "houseaaaaaaaa"));


            // TODO: Equals just returns a regular Boolean
            Console.WriteLine(str2.Equals(str3));
            Console.WriteLine(str2.ToUpper().Equals(str3.ToUpper()));


            // TODO: String Searching
            Console.WriteLine(str1.IndexOf("o"));
            Console.WriteLine(str1.IndexOf("fox"));

            Console.WriteLine(str2.LastIndexOf("e"));
            Console.WriteLine(str2.LastIndexOf("is"));

            Console.WriteLine("str1: " + str1);
            Console.WriteLine(str1.Replace("fox", "RACOON"));
            Console.WriteLine("str1: " + str1);
            str1 = str1.Replace("fox", "RACOON");
            Console.WriteLine("str1: " + str1);

        }
    }
}
