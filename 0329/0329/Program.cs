using System;
using System.Diagnostics;

namespace _0329
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string output = "";
            //Setup the Process with the ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "C:\\WINNT\\system32\\cmd.exe";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            //Start the process
            Process proc = Process.Start(startInfo);
        }
    }
}
