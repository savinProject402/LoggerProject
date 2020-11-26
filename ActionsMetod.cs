using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProject
{
    class ActionsMetod
    {
        private static Logger _Logger; 
        public ActionsMetod()
        {
            _Logger = Logger.Task;
        }
        public void First()
        {
            _Logger.LogInfo("Start method: " + nameof(First));

        }
        public void Second()
        {
            _Logger.LogWarning("Skip logic in method: " + nameof(Second));
        }
        public void Trird()
        {
            throw new Exception("I broke a toilet ");
        }
    }
}
