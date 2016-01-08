using System;
using System.IO;

namespace LibraryCal
{
    public interface ILogger
    {
        void Log(string text);
    }
    public class FileLogger : ILogger
    {
        public void Log(String text)
        {
            File.AppendAllText(@"" + Path.GetFullPath(".") + "\\LogFile.txt",DateTime.Now.ToString() + " " + text + "\r\n");
        }
    }
}
