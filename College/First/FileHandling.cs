using System.IO;

namespace FileHandling
{
    class FH
    {
        public void CreateFolder()
        {
            if (Directory.Exists("D:\\Programming\\Csharp\\College\\First\\files"))
                Console.WriteLine("Folder exist");
            else
                Directory.CreateDirectory("D:\\Programming\\Csharp\\College\\First\\files");
        }

        public void DeleteFolder()
        {
            Directory.Delete("D:\\Programming\\Csharp\\College\\First\\files");
        }

        public void CreateFile(string fileName)
        {
            File.Create("D:\\Programming\\Csharp\\College\\First\\" + fileName);
        }

        public void WriteIntoFile(string message, string fileName)
        {
            File.WriteAllText("D:\\Programming\\Csharp\\College\\First\\" + fileName, message);
        }
    }
}
