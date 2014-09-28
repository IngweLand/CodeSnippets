using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            BringToFront(Process.GetProcessesByName("vmplayer")[0]);
            Console.ReadLine();
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private static void BringToFront(Process pTemp)
        {
            SetForegroundWindow(pTemp.MainWindowHandle);
        }
    }
}
