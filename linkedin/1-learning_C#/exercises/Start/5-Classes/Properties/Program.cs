﻿using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Book object
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // Access a couple of properties
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            // Set the ISBN and Price properties
            b1.ISBN = "100140447938";
            b1.Price = 24.95m;
            Console.WriteLine("book1 ISBN is " + b1.ISBN);
            Console.WriteLine("book1 Price is " + b1.Price);

            // Change the Name and Pagecount
            b1.Name = "Crime and Punishment";
            b1.PageCount = 652;
            Console.WriteLine(b1.Description);
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.PageCount);
        }
    }
}
