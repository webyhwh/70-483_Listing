using System;
using System.Threading;

namespace Listing_1_2
{
    public class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc:{0}", i);
                Thread.Sleep(1000);
            }
        }
    
        public static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod))
            {
                IsBackground = true
            };
            t.Start();
        }
    }
}
