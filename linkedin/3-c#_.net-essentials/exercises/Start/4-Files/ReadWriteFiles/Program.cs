﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Reading and Writing data from and to files

// Make sure the example file exists
using System.IO;

const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
  File.WriteAllText(filename, "Initial text");
}

// TODO 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, "extra test");

// TODO 4: A FileStream can be opened and written to until closed
using(StreamWriter sw = File.AppendText(filename)) {
  sw.WriteLine("Line 1");
  sw.WriteLine("Line 2");
  sw.WriteLine("Line 3");
}

// TODO 2: ReadAllText reads all the content from a file
string content;
content = File.ReadAllText(filename);
Console.WriteLine($"Text::: {content}");
