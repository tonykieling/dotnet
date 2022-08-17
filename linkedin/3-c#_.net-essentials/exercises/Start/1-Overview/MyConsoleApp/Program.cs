// See https://aka.ms/new-console-template for more information
// Console.Write("Whats you name? ");
// string? resp = Console.ReadLine();
// Console.WriteLine($"Hello, {resp}!");

OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine($"{thisOS.Platform} is this PC's OS.");
Console.WriteLine($" = {thisOS.Version}");

// string? x = Console.ReadLine();
// Console.WriteLine(x);