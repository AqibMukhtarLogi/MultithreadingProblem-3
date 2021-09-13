using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_4
{
    class Program
    {
        private delegate void PrintMessage(int c);

        private static void Print(int c)
        {
            for(int i = c; i <= 100; i += 10)
            Console.WriteLine("Thread: {0} Counter: {1}", Thread.CurrentThread.ManagedThreadId, i);
        }
        static void Main(string[] args)
        {
            PrintMessage pm = new PrintMessage(Print);
            int threadCount = 1;
            while (threadCount <= 10)
            {
                pm.BeginInvoke(threadCount, null, null);
                threadCount++;
            }
            Console.ReadKey();
        }
    }
}
