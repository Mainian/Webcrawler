using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webcrawler.Scrapper.ScrapBehavior;

namespace Webcrawler.Gathers
{
    public class Gather
    {
        public ScrapBehavior scrapBehavior;
        string url;

        public Gather(ScrapBehavior scrapBehavior, string url)
        {
            this.scrapBehavior = scrapBehavior;
            this.url = url;
        }

        public async Task<List<Object>> PerformScrapAsync()
        {
            return scrapBehavior.Scrap(await Scrapper.Scrapper.GetWebsiteSourceCodeAsync(url));
        }

        public List<Object> PerformScrap()
        {
            return scrapBehavior.Scrap(Scrapper.Scrapper.GetWebsiteSourceCodeSync(url));
        }

        public async Task<List<Object>> PerformScrapAsyncWebClient()
        {
            return scrapBehavior.Scrap(await Scrapper.Scrapper.GetWebsiteSourceCodeWebClient(url));
        }
    }
}
