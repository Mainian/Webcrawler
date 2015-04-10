using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Crawler.ScraperBehavior
{
    public class PhoneNumberScrapper: ScraperBehavior.ScrapperBehavior<Scrapable.ScrapableItem.PhoneNumber>
    {
        List<Scrapable.ScrapableItem.PhoneNumber> Scrap(string val)
        {
            List<Scrapable.ScrapableItem.PhoneNumber> phoneNumbers = new List<Scrapable.ScrapableItem.PhoneNumber>();
            return phoneNumbers;
        }
    }
}
