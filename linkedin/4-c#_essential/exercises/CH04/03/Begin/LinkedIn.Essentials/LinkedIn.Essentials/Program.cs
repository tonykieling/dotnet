// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

//var e = new ShiftWorker();
var e = new {
    FirstName = "Tony", 
    LastName = "Kieling",
    Kids = new string[] {"kid1", "kid2"}
};
e.Kids[1] = "new kid";

Console.WriteLine($"{e.FirstName} {e.LastName} {e.Kids[1]}");