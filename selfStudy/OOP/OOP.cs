
namespace selfStudy.OOP
{
    internal class OOP
    {
        // OOP
        const string WhatsIsOOP = $"# OBJECT ORIENTATION PROGRAMMING (OOP) is a programming methodoly based on data, " +
            $"instead of functions.\n" +
            $"The way the softwares are design consider objects, the logic is within that objects.\n" +
            $"It contains 4 basic principles:\n" +
            $"\t- Abstraction: It is the way a software is organized, abstracted." +
            $"It is the foundation that supports the others pillars.\n" +
            $"In C#, the key words Abstract and Interface (for classes) are used. Abstract for method is possible, a well.\n" +
            $"\t- Inheritance: It is the property of share features and pass them away from parents to child components," +
            $"they may be allowed to change or add new features.\n" +
            $"It is a great way to reuse code.\n" +
            $"\t- Encapsulation: It is when some class' details are hidden. It is a way to show only the necessary parts.\n" +
            $"\t- Polymorphism: It is the capacity of having the same method with different signatures " +
            $"(return or received data) - same action with different data.";

        // Class / Class Members, Properties
        const string WhatIsAClass = $"# CLASS is a data struct that holds the blueprint of objects.\n" +
            $"It contais fiels (properties) and methods (functions) to perform actions on its fields.";
        
        // Object
        const string WhatIsAnObject = $"# OBJECT is a class instanciation.\n" +
            $"It will have all class members of that particular class, such as fields and methods.\n" +
            $"When the 'new' word is used, it means an object has been created.\n" +
            $"An Object has 3 things:\n" +
            $"\t- identity (name, type)\n" +
            $"\t- attributes (properties, data)\n" +
            $"\t- behaviours (methods, operations)";
        
        // Constructor / Overload constructor
        const string WhatIsAConstructor = $"# CONSTRUCTOR is the method that runs automatically when a class is instanciated.\n" +
            $"That means, it will be executed when an object is created.\n" +
            $"It is used to set initial states or receive parameters.";
        
        // Parametrs and array params
        // DIFF BTW (int[] list) X (params int[] list) X (string[] args)
        const string Params = $"# PARAMS ........"
        
        // Modifiers - Static, internal, 
        const string WhatisAModifier = $"# MODIFIERS are .......";
        
        // Overloading vs Overriden vs Overwrite
        const string Overs = $"# Overload .......\N" +
            $" Overriden is ........\n" +
            $" Overwrtien is ............";
        
        // Arrays, List, 
        // https://docs.microsoft.com/en-us/shows/csharp-101/csharp-arrays-list-and-collections
        const string ArraysLike = $"# Arrays are .......\n" +
            $" Lists is .....\n" +
            $" Collections are";

        readonly string[] Concepts =
        {
            WhatsIsOOP,
            WhatIsAClass,
            WhatIsAnObject,
            WhatIsAConstructor,
            Params,
            WhatisAModifier,
            Overs,
            ArraysLike,

        };

        public OOP()
        {
            for (int i = 0; i < Concepts.Length; i++)
            {
                Console.WriteLine(Concepts[i] + "\n");
                Console.ReadKey();
            }

        }
        public static void Test()
        // this method will be executed directly in the OOP class, not in its objects
        // it means it belongs to the class instead of to an object
        {
            Console.WriteLine("there we go!");
        }

    }
}
