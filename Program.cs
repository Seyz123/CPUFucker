using System;
using System.Collections.Generic;
using System.Threading;

namespace CPUFucker
{
    class Program
    {
        public static List<Thread> Threads1 = new List<Thread>();
        public static List<Thread> Threads2 = new List<Thread>();
        public static List<Thread> Threads3 = new List<Thread>();
        public static Random Rand = new Random();
        
        static void Main(string[] args)
        {
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