// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

string input = null;
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

//age = null;
age = 15;
age ??= 81; // when age is null, then it will be 81
definiteInt = age ?? 17; // if age is null, then the result of this will be 17
// same as
//definiteInt = (age != null) ? age.Value : 17;
Console.WriteLine($"definiteInt: {definiteInt}");

//if(age != null)
//{
//    Console.WriteLine($"Age is: {age}");
//}

//if(age.HasValue)
//{
//    Console.WriteLine($"Age is: {age.Value}");
//}