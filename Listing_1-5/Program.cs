using System;
using System.Threading;

namespace Listing_1_5
{
    class Program
    {
        [ThreadStatic]
        public static int _field;
        public static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("ThreadA: {0}", _field);
                }
            }).Start();

            new Thread(()=>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("ThreadB: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
