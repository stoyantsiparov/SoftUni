namespace CopyDirectory
{
    using System;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            // Ако директорията съществува е трия (ако е пълна с файлове се трие рекурсивно (отвътре))
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, recursive: true);
            }
            // Създавам копие, което е празно
            Directory.CreateDirectory(outputPath);

            // Взимам всички файлове в оригиналната директория (папка)
            string[] files = Directory.GetFiles(inputPath);

            // Обикалям оригиналната директория (папка)
            foreach (string file in files)
            {
                // Взимам имената на елементите в оригиналната директория (папка)
                string fileName = Path.GetFileName(file);

                // Комбинира директорията с елементите от оригиналната директория
                string destination = Path.GetDirectoryName(file);

                // Копирам файловете в празната копирана директория (папка) от оригиналната
                File.Copy(file, destination);
            }
        }
    }
}