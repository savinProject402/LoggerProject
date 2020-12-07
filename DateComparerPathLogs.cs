namespace LoggerProject
{
    using System;
    using LoggerProject.Services;
    using System.Collections.Generic;
    using System.IO;
    public class DateComparerPathLogs : IComparer<FileInfo>
    {
        public int Compare(FileInfo intX, FileInfo intY)
        {
            if (intX.CreationTimeUtc < intY.CreationTimeUtc)
            {
                return 1;
            }
            if (intX.CreationTimeUtc > intY.CreationTimeUtc)
            {
                return - 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
