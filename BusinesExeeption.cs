namespace LoggerProject
{
    using System;
    public class BusinesExeeption : Exception
    {
        public BusinesExeeption(string message)
            : base(message)
        { 
        }
    }
}
