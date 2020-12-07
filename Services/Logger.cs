namespace LoggerProject
{
    using System;
    using LoggerProject.Interfaces;
    using LoggerProject.Services;
    public class Logger : Ilogger
    {
        private static readonly Logger fileInterfaceServise = new Logger();
        private readonly FileService fileService;
        private Logger()
        {
            this.fileService = FileService.InterfaceServise;
        }
        public static Logger InterfaceServise = fileInterfaceServise;
        public void LogError(string message, Exception exp = null)
        {
            this.Log(WriteErrorsEnum.Error, exp != null ? $"{message}:{exp}" : message);
        }
        public void LogInfo(string message)
        {
            this.Log(WriteErrorsEnum.Info, message);
        }
        public void LogWarning(string message)
        {
            this.Log(WriteErrorsEnum.Warning, message);
        }
        public void Log(WriteErrorsEnum writeErrors, string message)
        {
            var result = $"{DateTime.UtcNow:hh:mm:ss}:{writeErrors}:{message}";
            this.WriteDateTime(result);
        }
        public void WriteDateTime(string datetime)
        {
            this.fileService.Write(datetime);
            Console.WriteLine(datetime);
        }

    }
}
