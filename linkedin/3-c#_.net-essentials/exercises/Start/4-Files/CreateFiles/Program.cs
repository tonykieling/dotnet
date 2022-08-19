// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
// using(StreamWriter sw = File.CreateText(filename)) {
//   sw.WriteLine("This is a piece of text in a test.");
// }


// TODO: Determine if a file exists
bool fileExist = File.Exists(filename);
Console.WriteLine($"before - Does {filename} exist? {fileExist}");
if (fileExist)
  File.Delete(filename);
else {
  using(StreamWriter sw = File.CreateText(filename)) {
    sw.WriteLine("This is a piece of text in a test.");
  }
}

Console.WriteLine($"after - Does {filename} exist? {File.Exists(filename)}");
