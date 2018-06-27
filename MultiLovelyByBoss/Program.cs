using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace MultiLovelyByBoss
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string windowClass, string windowName);

        [DllImport("user32.dll")]
        static extern bool SetWindowText(IntPtr hWnd, string text);

        static void Main(string[] args)
        {
            List<Process> processos = new List<Process>(Process.GetProcessesByName("elementclient"));
            int count = 0;
            foreach (var processo in processos)
            {
                SetWindowText(processo.MainWindowHandle, "Multi-Lovely By Boss " + (++count));
            }
            Process.Start(Directory.GetCurrentDirectory() + "\\launcher.exe");
        }
    }
}
