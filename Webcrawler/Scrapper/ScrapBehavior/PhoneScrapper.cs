using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webcrawler.Scrapper.ScrapableItems;
using System.Text.RegularExpressions;

namespace Webcrawler.Scrapper.ScrapBehavior
{
    public  class PhoneScrap : ScrapBehavior<PhoneNumber>
    {
        List<PhoneNumber> Scrap(string text)
        {
            List<PhoneNumber> phoneNumebrs = new List<PhoneNumber>();

            //Regex myRegex = ScrapExpression();
            foreach (Regex myRegex in ScrapExpressions())
            {
                String[] vals = Regex.Split(text, myRegex.ToString());

                foreach (Match m in myRegex.Matches(text))
                {
                    PhoneNumber phoneNumber = new PhoneNumber();
                    phoneNumber.Number = m.ToString();
                    phoneNumebrs.Add(phoneNumber);
                }
            }
            return phoneNumebrs;
        }

        List<Regex> ScrapExpressions()
        {
            List<Regex> scrapableExpressions = new List<Regex>();
            Regex scrapableExpression = new Regex(@"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$");

            scrapableExpressions.Add(scrapableExpression);
            return scrapableExpressions;
        }
    }
}
