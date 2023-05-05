using System;

namespace Lab01Q4
{
    class Prog
    {
        static public void Run(string[] args)
        {
            string path = @"C:\MyFolder";

            // Create a directory (folder) in the specified path
            Directory.CreateDirectory(path);

            // Create a file in the directory
            string filePath = Path.Combine(path, "MyFile.txt");
            File.WriteAllText(filePath, "Hello, world!");

            // Select the file and print its contents
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine(fileContents);

            // Select the directory and print its contents
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Console.WriteLine($"Directory: {directoryInfo.FullName}");
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine($"File: {file.Name}");
            }

            Console.ReadKey();
        }
    }
}