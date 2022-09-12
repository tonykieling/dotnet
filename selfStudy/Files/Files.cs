
namespace selfStudy.Files
{
    internal class Files
    {
        public Files()
        {
            Console.WriteLine("FIles running");
            DirectoryInfo currDir = new DirectoryInfo(".");

            Console.WriteLine("currDir: " + currDir.FullName);
            Console.WriteLine("currDir: " + currDir.Name);
            Console.WriteLine("currDir: " + currDir.Parent);
            Console.WriteLine("currDir: " + currDir.Attributes);
            Console.WriteLine("currDir: " + currDir.CreationTime);

            string newDir = $"{currDir.FullName}\\testCSharp";
            if (!Directory.Exists(newDir))
                Directory.CreateDirectory(newDir);
            //Console.ReadLine();
            //Directory.Delete(newDir);

            string textFilePath = $"{newDir}\\test.txt";
            //string[] textArr = { "1 is a short line", "22 is shorter that 11", "333 should be a long one, but it is not." };
            //File.WriteAllLines(textFilePath, textArr);
            if (File.Exists(textFilePath))
                Console.WriteLine("file!");
            else Console.WriteLine("NOOOO file"); ;
            File.AppendAllText(textFilePath, "4 this is 444444444");
            foreach (string text in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine(text);
                string[] line = text.Split();
                for (int i = 0; i < line.Length; i++)
                    Console.WriteLine($"{i + 1} item is: {line[i]}");
                break;
            }
            ////Directory.CreateDirectory
            ////Console.WriteLine("currDir: " + currDir.FullName);
            
        }
    }
}
