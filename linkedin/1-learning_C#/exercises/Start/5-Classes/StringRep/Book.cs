using System;

namespace StringRep {
    class Book {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; }

        public Book(string name, string author, int pages) {
            Console.WriteLine("book:::", name, author, pages);
            Name = name;
            Author = author;
            PageCount = pages;
        }

        // TODO: The ToString method generates a string represenation of the object
        public override string ToString() {
            return $"This is a new definition of ToString() - {Name} by {Author}, {PageCount} pages.";
        }


        // TODO: ToString can be overloaded to give different format versions
        // Notice that this version is NOT an override function
        public string ToString(char b) {
            if (b == 'B') return $"BBB - Book: {Name}:{Author}";
            else if (b == 'F') return $"FFF - {Name} by {Author}";
            else return ToString();
        }
        // ??? override VERSUS overload
        /*
 Overloading is the ability to have multiple methods within the same class with the same name, but with different parameters. Each of these methods has their own implementation as well, meaning that they can behave differently depending on what is passed in.
 Overloading is known as compile-time (or static) polymorphism because each of the different overloaded methods is resolved when the application is compiled. 

 Overriding is the ability to redefine the implementation of a method in a class that inherits from a parent class. When a method is overridden, the name and the parameters stay the same, but the implementation that gets called depends on the type of the object that's calling it.
 Overriding is known as runtime (or dynamic) polymorphism because the type of the calling object is not known until runtime, and therefore the method implementation that runs is determined at runtime. 
        */

    }
}