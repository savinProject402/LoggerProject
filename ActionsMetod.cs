using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProject
{
    public class ActionsMetod
    {
        private static Logger _Logger; 
        public ActionsMetod()
        {
           _Logger = Logger.InterfaceServise;
        }
        public void First()
        {
            _Logger.LogInfo("Start method: " + nameof(this.First));

        }
        public void Second()
        {
            throw new BusinesExeeption("Skip logic in method: " + nameof(this.Second));
        }
        public void Trird()
        {
            throw new Exception("I broke a toilet ");
        }
    }
}
