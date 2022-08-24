// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;
using Newtonsoft.Json;

Employee e = new Manager();
e.FirstName = "1st name";
Console.WriteLine($"Employe: {e.FirstName}");

string db = Constants.CONFIG_DB_NAME;
Console.WriteLine(db);

JsonSerializer j = new JsonSerializer();
j.Serialize(Console.Out, e);
