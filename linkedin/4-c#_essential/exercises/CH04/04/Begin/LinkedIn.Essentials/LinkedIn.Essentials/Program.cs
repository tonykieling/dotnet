// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

//anonymous type:
//var e = new
//{
//    FirstName = "Matt",
//    LastName = "Milner",
//    Kids = new string[] { "son1", "son2" }
//};
//var d = new ShiftWorker() { FirstName = "NAmE", LastName = "Surname" };
//d. // it is okay bkz var has an implicit declaration for the current variable
dynamic d = new ShiftWorker() { FirstName = "NAmE", LastName = "Surname" };
//d. nothing happens bkz in a dynamic type the compiler does not check,
//also means the coder can do whatver they want, such as create other properties
// the system will figure out at run time, not complile time
//string kid1 = e.Kids[1];
Console.WriteLine(d.FirstName);