using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_21
{
    class Program
    {
        static async Task MainAsync(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync("http://www.microsoft.com")
            .ConfigureAwait(false);

            using (FileStream sourceStream = new FileStream("temp.html",
            FileMode.Create, FileAccess.Write, FileShare.None,
            4096, useAsync: true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                .ConfigureAwait(false);
            };
        }
    }
}
