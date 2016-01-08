using System;
using System.IO;
using LibraryCal;

namespace ConsoleCal
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==3)
            {
                if ((args[0].Equals("-divide") || args[0].Equals("/")) && args[2].Equals("0")) Console.WriteLine("error");
                else Console.WriteLine(new Calculator(args[0] + "", args[1], args[2], new FileLogger()).Cal());
            }
            else
            {
                System.Diagnostics.Process.Start(@"" + Path.GetFullPath(".")+"\\FormCal.exe");
            }
        }
    }
}
