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
            get;  set;
        }

        public static Logger Task => logger;



    }
}
