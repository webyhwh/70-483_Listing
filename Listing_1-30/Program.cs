using System;
using System.Collections.Concurrent;

namespace Listing_1_30
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>
            {
                42,
                21
            };

            int result;

            if (bag.TryTake(out result))
                Console.WriteLine(result);

            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);
        }
    }
}
