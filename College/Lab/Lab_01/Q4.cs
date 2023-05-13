using System;

namespace Lab01Q4
{
    class Prog
    {
        static public void Run(string[] args)
        {
            string path = @"D:\CsharpExample";

            // Create a directory:
            Directory.CreateDirectory(path);

            // Create a file:
            string filePath = Path.Combine(path, "hello.txt");
            File.WriteAllText(filePath, "Hello, world!");

            // Select the file and print its contents:
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine(fileContents);

            // Select the directory and print its contents:
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
