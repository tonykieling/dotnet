using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix = "", string a = "", string b = "B")
{
    Console.WriteLine($"{prefix} {thestr} {a} {b}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hello there!");
PrintWithPrefix("Hello there once again!", "-prefix-");

// TODO: Call with named params
PrintWithPrefix(prefix: "---", thestr: "My string");
PrintWithPrefix(prefix: "---", a: "AAA", thestr: "My string");
PrintWithPrefix("test string", prefix: "---");
PrintWithPrefix("_thestr_", "-this is prefix-", "AAA", "BB");
