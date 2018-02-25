using System;
using System.Threading;

namespace Listing1_6
{
    class Program
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("ThreadA: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("ThreadB: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
