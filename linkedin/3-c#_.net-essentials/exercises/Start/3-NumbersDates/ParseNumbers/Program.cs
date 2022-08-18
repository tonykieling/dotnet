// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing numerical data from strings

using System;

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 ", "XYZ"};

int testint;
float testfloat;
bool result;

/*
https://www.youtube.com/watch?v=TJlt-LiqVCY
how to set a keyboard shortcut
f1 + "Configure User Snippets"
*/

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
// foreach (string str in NumStrs) {
//   try {
//     testfloat = float.Parse(str);
//     Console.WriteLine($"testfloat = {testfloat}");
//     testint = int.Parse(str);
//     Console.WriteLine($"inttest = {testint}");
//   } catch(FormatException e) {
//     Console.WriteLine($"XXXError: Could not parse {str} - {e.Message}");
//   } finally {
//     Console.WriteLine($"\n");
//   }
// }

// TODO: The TryParse method returns 'true' if the parse is successful
foreach (string s in NumStrs) {
  result = int.TryParse(s, out testint);
  if (result) {
    Console.WriteLine($"result is: {s} ===> parsed to INT");
  } else {
    result = float.TryParse(s, out testfloat);
    if (result)
      Console.WriteLine($"result is: {s} ===> parsed to FLOAT");
    else
      Console.WriteLine($"{s} NOT PARSED TO INT NEITHER TO FLOAT");
  }
}
