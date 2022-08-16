namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x = 10, y = 5;
            string a = "abcd", b = "efgh";

            // TODO: Basic math operators are +, -, /, *
            Console.WriteLine("----- Basic Math -----");
            Console.WriteLine( (x / y) * y);
            Console.WriteLine( a + b);

            // TODO: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            x++;
            y--;

            // TODO: Operators can be shorthand: a = a + b
            x += 2;
            y += 3;
            Console.WriteLine("New x is: " + x + " and y is: " + y);


            // TODO: Logical operators &&, ||
            // Console.WriteLine("----- Logic Operators -----");
            // Console.WriteLine(x > y && x > 0);
            // Console.WriteLine((x < y || y < 0) ? "XXXX" : "Y < 0");


            // null-coalescing operators
            string str = null;
            // TODO: the ?? operator uses left operand if not null, or right one if it is
            Console.WriteLine(str ?? "str is 'null'");

            
            // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }
            str ??= "new value for str";
            Console.WriteLine("str value is '" + str + "'");

        }
    }
}
