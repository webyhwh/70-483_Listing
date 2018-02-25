﻿using System;
using System.Threading.Tasks;

namespace Listing_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result); // Displays 84
        }
    }
}
