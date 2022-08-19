

string targetDir = "FileCollection";

List<string> files = new List<string>(Directory.EnumerateFiles(targetDir));
// Console.WriteLine($"files: {files}");
long excel = 0, word = 0, powerpoint = 0, 
  excelSize = 0, wordSize = 0, powerpointSize = 0,
  totalFiles = 0, totalSize = 0;

foreach (string file in files) {
  Console.Write($"- {file} - ");
  FileInfo fi = new FileInfo(file);
  string ext = fi.Extension;
  long size = (fi.Length);
  Console.Write($"{fi.Name} => {ext} - {size}\n");

  if (ext == ".xlsx") {
    excel++;
    excelSize += size;
    totalFiles++;
    totalSize += size;
  } else if (ext == ".docx") {
    word++;
    wordSize += size;
    totalFiles++;
    totalSize += size;
  } else if (ext == ".pptx") {
    powerpoint++;
    powerpointSize += size;
    totalFiles++;
    totalSize += size;
  }
  // else {
  //   totalFiles--;
  // }
}

Console.WriteLine($" ----- Results -----");
Console.WriteLine($"Total Files: {totalFiles}");
Console.WriteLine($"Excel Count: {excel}");
Console.WriteLine($"Word Count: {word}");
Console.WriteLine($"PP Count: {powerpoint}");
Console.WriteLine($"------------");
Console.WriteLine($"Total Size: {totalSize.ToString("#,#")}");
Console.WriteLine($"Excel Size: {excelSize:N0}");
Console.WriteLine($"Word Size: {wordSize}");
Console.WriteLine($"PP Size: {powerpointSize.ToString("#,#")}");

