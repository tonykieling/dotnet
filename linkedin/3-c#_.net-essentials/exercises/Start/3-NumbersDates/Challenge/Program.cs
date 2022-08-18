// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

string? input;
DateTime userDate;
// DateTime today = DateTime.Now;   // now will get hours, minutes and seconds   ---- it considers time, as well
DateTime today = DateTime.Today;
bool parseDate;
Console.WriteLine($"= Today is: {today}");

while (1 == 1) {
  Console.Write($"\nWhich date? ");
  input = Console.ReadLine();
  
  if (input.ToLower() == "exit") break;

  parseDate = DateTime.TryParse(input, out userDate);

  // also, it is possible to use <TimeSpan> type to get the difference btw days (not sure whether it will be different from mine solution)
  if (parseDate) {
    Console.WriteLine($"  Your date was parsed to: {userDate: MMMM dd, yyyy}");
    if (userDate > today) {
      Console.WriteLine($"  ===> That date will be in {(userDate - today).Days} days.");
    } else if (userDate < today) {
      Console.WriteLine($"  ===> That date went by {(today - userDate).Days} days ago!");
    } else
      Console.WriteLine($"  ===> That date is today!");
  } else
    Console.WriteLine($" - ERROR: {input} does NOT seem to be a valid date. :/");
}

