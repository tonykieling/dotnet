// using System;

namespace Comments
{
    ///<summary>
    /// This is a class TEST!
    ///</summary>
    public class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        static void Main(string[] args)
        {
            // XML documentation
            // https://docs.microsoft.com/en-us/dotnet/csharp/codedoc
            Console.WriteLine("Hello World!");

            /*
                see Comments.csproj, lines 8 and 9
                after running dotnet build, it will generate the xml doc file
            */

        }

        // void helloWorld() {
        //     Console.WriteLine("inside Hello World method!");

        // }
    }

    // Program mobj = new Program();
    

}
