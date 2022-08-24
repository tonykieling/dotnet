// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;
//using System;
using Newtonsoft.Json;

Employee e = new Manager();
e.FirstName = "Hello";
JsonSerializer s = new JsonSerializer();
s.Serialize(Console.Out, e);

//string server = Constants.CONFIG_DB_NAME;
//Console.WriteLine(server);

Console.WriteLine(e.FirstName);