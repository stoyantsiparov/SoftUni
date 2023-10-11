using System.IO.Compression;

namespace ZipAndExtract
{
    using System;
    using System.IO;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            string fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            // Създавам зип папка 
            using ZipArchive archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);

            // Търся името на дадения файл за копиране
            string fileName = Path.GetFileName(inputFilePath);

            // Копирам (създавам) даден файл в зип папката
            archive.CreateEntryFromFile(inputFilePath, fileName);
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            // Отварям зип папкака за четене
            using ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath);

            // От отворената зип папка взимам файла с дадено име
            ZipArchiveEntry fileForExctaction = archive.GetEntry(fileName);

            // Изкарва файла в директорията от зип папката
            fileForExctaction.ExtractToFile(outputFilePath);
        }
    }
}