using System;
using System.Threading.Tasks;

namespace Listing_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }
            });
            t.Wait();
        }
    }
}
