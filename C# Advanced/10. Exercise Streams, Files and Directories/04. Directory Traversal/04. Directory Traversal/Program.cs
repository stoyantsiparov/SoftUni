using System.Text;

namespace DirectoryTraversal
{
    using System;
    using System.IO;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            //{FileInfo} е клас който дава информация за файлове (име, размер и т.н.)
            SortedDictionary<string, List<FileInfo>> extensionsFiles = new();
            //{Directory} е клас който взима файлове в определена директория (папка)
            string[] fileNames = Directory.GetFiles(inputFolderPath);

            foreach (string fileName in fileNames)
            {
                FileInfo fileInfo = new(fileName);

                if (!extensionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }

                extensionsFiles[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new();

            foreach (var extensionsFile in extensionsFiles.OrderByDescending(ef => ef.Value.Count))
            {
                sb.AppendLine(extensionsFile.Key);

                foreach (var file in extensionsFile.Value.OrderBy(f => f.Length))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:F3}kb");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            // Environment помагащ клас с много методи (позволява да достъпя пътя към десктопа и да запиша дадени елементи там)
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}