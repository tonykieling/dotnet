// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// // TODO: Length of a string 
// Console.WriteLine($"{str2}");
// Console.WriteLine($"str2.Length: {str2.Length}");

// // TODO: Access individual characters
// Console.WriteLine($"str2.Length[10]: {str2[10]}");

// // TODO: Iterate over a string like any other sequence of values
// int i = 1;
// foreach(char c in str2) {
//   Console.Write(c == (str2.Length - 1) ? c : $"{c}({i})");
//   // Console.Write(c != ' ' ? $"({i}-{c})" : " ");
//   // Console.Write($"{c}({i})");
//   i++;
// }
// Console.WriteLine("\n");

// // TODO: String Concatenation         
// string? outstr;
// outstr = String.Concat(strs);
// Console.WriteLine($"outstr: {outstr}");

// // TODO: Joining strings together with Join
// Console.WriteLine(String.Join('.', strs));
// outstr = String.Join('.', strs);
// Console.WriteLine($"strs after join: {outstr}");
// // Console.Write($"{String.Split(str3)}");

// TODO: String Comparison
// bool check = str2.Equals(str3);


// Equals just returns a regular Boolean
// bool isEqual = str2.Equals(str3);
// Console.WriteLine($"{isEqual}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
// Console.WriteLine($"check is: {check}");
// Console.WriteLine($"compare: {String.Compare("abc", "abd")}");
// Console.WriteLine($"compare: {String.Compare("abc", "abc")}");
// Console.WriteLine($"compare: {String.Compare("abc", "abb")}");


// TODO: Replacing content
Console.WriteLine($"str1: {str1}");
string strx = str1.Replace("fox", "CAT");
Console.WriteLine($"strx: {strx}");
Console.WriteLine($"str1: {str1}");
