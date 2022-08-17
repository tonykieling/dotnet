// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting string content

float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes
Console.WriteLine("{0, -15} {1,20}", "Float val", "Integer val");
Console.WriteLine("{0, -15} {1,20}\n", f1, i1);

// TODO: Spacing and Alignment: Interpolation
Console.WriteLine("{0, -15} {1,20}", "Float val", "Integer val");
Console.WriteLine($"{f1, -15} {i1,20}");

