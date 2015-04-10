using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Crawler.ScraperBehavior
{
    public interface ScrapperBehavior<Scrapable.Scrapable>
    {
        List<Scrapable.Scrapable> Scrap(string val);
    }
}
