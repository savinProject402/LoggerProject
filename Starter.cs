using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProject
{
    class Starter
    {
        private readonly ActionsMetod actionsmetod;
        private readonly Logger logger;
        public Starter()
        {
            actionsmetod = new ActionsMetod();
            logger = Logger.Task;
        }

        public void Run()
        {
            var rand = new Random();
            for (var i = 0; i < 100; i++)
            {
                try
                {
                    var rew = rand.Next(1, 100);

                    if (rew<30)
                    {
                        actionsmetod.First();
                    }

                   else if (rew>31 & rew < 89)
                    {
                        actionsmetod.Second();
                    }
                    
                   else if (rew > 90)
                    { actionsmetod.Trird(); }
                    
                    
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message, ex);
                }
            }
            var writeLog = new InsertLogsInFile();
            writeLog.WriteLogsIn(logger);
        }
    }
}
