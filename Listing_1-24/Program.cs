using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_24
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
            .Where(i => i % 2 == 0)
            .ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}
