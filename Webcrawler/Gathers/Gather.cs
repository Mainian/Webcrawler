using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webcrawler.Scrapper.ScrapBehavior;

namespace Webcrawler.Gathers
{
    public abstract class Gather<T>
    {
        public ScrapBehavior<T> scrap;
        string url;

        public Gather(ScrapBehavior<T> scrapBehavior, string url)
        {
            this.scrap = scrapBehavior;
            this.url = url;
        }

        public List<T> performScrap()
        {
            return scrap.Scrap(url);
        }
    }
}
