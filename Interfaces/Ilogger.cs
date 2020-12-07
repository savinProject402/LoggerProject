namespace LoggerProject.Interfaces
{
    using System;
    public interface Ilogger
    {
        void LogError(string message, Exception ex = null);
        void LogInfo(string message);
        void LogWarning(string messag);
        void Log(WriteErrorsEnum writeErrorsEnum, string message);
    }
}
