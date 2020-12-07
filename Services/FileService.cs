namespace LoggerProject.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class FileService
    {
        private const string FileType = ".txt";
        private const string FileTimeType = "hh.mm.ss dd.MM.yyyy";
        private const int CountFileSave = 3;
        private static readonly string LogsDirectory = "Logs\\";
        private static readonly FileService fileInterfaceServise = new FileService();
        private readonly string fileNames;
        private readonly double timeLifeFile = 2;
        private readonly StreamWriter streamWriter;

        private FileService()
        {
            this.CheckLogsDirectory();
            this.CheckLogsInDirectory();
            this.fileNames = $"{DateTime.UtcNow.ToString(FileTimeType)}{FileType}";
            this.streamWriter = new StreamWriter($"{LogsDirectory}{this.fileNames}", true);
        }
        public static FileService InterfaceServise => fileInterfaceServise;
        public static string GetfileNames(string str)
        {
            var result = str.Replace($"{FileType}", string.Empty).Replace(FileService.LogsDirectory, string.Empty).Split(' ');
            return $"{result[1].Replace(".","/")} {result[0].Replace(".",":")}";
        }
        public void Write(string text)
        {
            this.streamWriter.WriteLine(text);
        }
        private void CheckLogsDirectory()
        {
            if(!Directory.Exists(LogsDirectory))
            {
                Directory.CreateDirectory(LogsDirectory);
            }
        }
        private void CheckLogsInDirectory()
        {
            var fileInLogs = Directory.GetFiles(LogsDirectory, $"{FileType}", SearchOption.TopDirectoryOnly);
            if (fileInLogs.Length > 0)
            {
                List<FileInfo> files = new List<FileInfo>();
                foreach (string path in fileInLogs)
                {
                    files.Add(new FileInfo(path));
                }

                files.Sort((IComparer<FileInfo>) new DateComparerPathLogs());
                for (int i = 0; i < files.Count; i++)
                {
                    if (DateTime.UtcNow - files[i].CreationTimeUtc > TimeSpan.FromDays(this.timeLifeFile) || i >= CountFileSave - 1)
                    {
                        this.DeleteLogsFiles(files[i].FullName);
                    }
                }
            }
        }
        private void DeleteLogsFiles(string path)
        {
            File.Delete(path);
        }
    }
}
