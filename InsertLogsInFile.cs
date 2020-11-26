using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerProject
{
    class InsertLogsInFile
    {
        public void WriteLogsIn(Logger logger) // нужен класс Logger
            {
            File.WriteAllText("Logs.txt", logger.MessageRead.ToString());
            }
    }
}
