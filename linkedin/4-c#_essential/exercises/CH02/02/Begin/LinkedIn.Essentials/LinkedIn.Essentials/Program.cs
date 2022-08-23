// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Console.WriteLine("Hello World");
Employee e = new Employee("Tony", "K+", 8);
Console.WriteLine($"\n\tName is: {e.FirstName} {e.LastName}, Id is: {e.Id}");
