using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float milesToKms(float miles) {
  float result = miles * 1.6f;
  return result;
}

// TODO: A function with no return value has a 'void' type
void printFormatted(string str) {
  Console.WriteLine($"   \n---   {str}   ---\n");
}

// TODO: Call first function
Console.WriteLine(milesToKms(10f));
Console.WriteLine(milesToKms(5.5f));

// TODO: Call second function
printFormatted("Tony");
printFormatted("something else");