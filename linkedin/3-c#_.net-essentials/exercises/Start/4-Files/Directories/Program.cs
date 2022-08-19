// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if (!Directory.Exists(dirname))
//   Directory.CreateDirectory(dirname);
// else
//   Directory.Delete(dirname);

// TODO: Get the path for the current directory
string curPath = Directory.GetCurrentDirectory();
// Console.WriteLine($"current dir: {curPath}");

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo di = new DirectoryInfo(curPath);
// Console.WriteLine($"{di.Name}");
// Console.WriteLine($"{di.Parent}");
// Console.WriteLine($"{di.CreationTime}");
// Console.WriteLine($"{di.GetType()}");


// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> theDirs = new List<string>(Directory.EnumerateDirectories(curPath));
foreach (string dir in theDirs)
  Console.WriteLine($"-{dir}");
Console.WriteLine("---------------\n");

Console.WriteLine("Just files:");
List<string> theFiles = new List<string>(Directory.EnumerateFiles(curPath));
foreach (string file in theFiles)
  Console.WriteLine($"-{file}");
Console.WriteLine("---------------\n");

Console.WriteLine("All directory contents:");
List<string> theAll = new List<string>(Directory.EnumerateFileSystemEntries(curPath));
foreach (string item in theAll)
  Console.WriteLine($"-{item}");
Console.WriteLine("---------------\n");

