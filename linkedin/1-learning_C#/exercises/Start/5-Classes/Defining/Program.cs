using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("asd", "TK", 159);
            Book b2 = new Book("asd asd", "TKieling", 321);

            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

            // TODO: try to set one of the properties -- 
            // this will result in an error
            // b1._name = "Another book's name";   ////////////// it will not work bkz _name is private
            // Console.WriteLine(b1.GetDescription());


        }
    }
}
