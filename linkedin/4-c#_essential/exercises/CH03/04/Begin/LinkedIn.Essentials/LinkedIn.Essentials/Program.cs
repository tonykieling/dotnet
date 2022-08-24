// See https://aka.ms/new-console-template for more information
using LE = LinkedIn.Essentials;
//using System;
using Newtonsoft.Json;
using LET = LinkedIn.Essentials.Types;

LE.Employee e = new LE.Manager();
e.FirstName = "Hello";
JsonSerializer s = new JsonSerializer();
s.Serialize(Console.Out, e);

//e.IsActive();

Console.WriteLine(e.FirstName);