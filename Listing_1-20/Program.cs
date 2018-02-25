using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_20
{
    class Program
    {
        static async Task MainAsync(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);

            Output.Content = content;
        }
    }
}
