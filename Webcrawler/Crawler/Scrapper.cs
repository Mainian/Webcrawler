using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Webcrawler.Crawler
{
    public class Scrapper
    {
        public static async Task<string> GetWebsiteSourceCodeAsync(string url)
        {
            string sourceCode = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                using(HttpWebResponse resp = (HttpWebResponse)await req.GetResponseAsync())
                    using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                        sourceCode = await sr.ReadToEndAsync();
            }
            catch (WebException webException)
            {
                Console.WriteLine(webException.ToString());
            }

            return sourceCode;
        }

        public static string GetWebsiteSourceCodeSync(string url)
        {
            string sourceCode = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
                    using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                        sourceCode = sr.ReadToEnd();
            }
            catch (WebException webException)
            {
                throw webException;
            }

            return sourceCode;
        }

        public static async Task<string> GetWebsiteSourceCodeWebClient(string url)
        {
            string getString = "";
            WebClient client = new WebClient();
            try
            {
                getString = await client.DownloadStringTaskAsync(url);
            }
            catch (WebException webException)
            {
                throw webException;
            }

            return getString;
        }
    }
}
