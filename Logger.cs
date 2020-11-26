using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProject
{
    class Logger
    {
        public static Logger logger = new Logger();

        private Logger()
        {
            MessageRead = new StringBuilder();
        }
        public StringBuilder MessageRead
        {
            get; private set;
        }

        public static Logger Task => logger;

        public void LogError(string message, Exception ex = null)
        {
            var result = WriteErrorsEnum.LogEnum.Error + message;
            if (ex != null)
            {
                result += "\t trase: \n " + ex.StackTrace;
            }
            MessageRead.AppendLine(result);
            Console.WriteLine(result);
        }
        public void LogInfo(string message)
        {
            Log(WriteErrorsEnum.LogEnum.Info, message);
        }
        public void LogWarning(string message)
        {
            Log(WriteErrorsEnum.LogEnum.Warning, message);
        }
        public void Log(WriteErrorsEnum.LogEnum LevelLog, string message)
        {
            var result = LevelLog + "\t Message: " + message;
            MessageRead.AppendLine(result);
            Console.WriteLine(result);
        }

    }
}
