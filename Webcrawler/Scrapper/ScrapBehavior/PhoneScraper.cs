using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webcrawler.Scrapper.ScrapableItems;
using System.Text.RegularExpressions;

namespace Webcrawler.Scrapper.ScrapBehavior
{
    public class PhoneScraper : ScrapBehavior
    {
        public List<Object> Scrap(string text)
        {
            List<Object> phoneNumbers = new List<Object>();

            //Regex myRegex = ScrapExpression();
            foreach (Regex myRegex in ScrapExpressions())
            {
                String[] vals = Regex.Split(text, myRegex.ToString());

                foreach (Match m in myRegex.Matches(text))
                {
                    var numbers = phoneNumbers.OfType<PhoneNumber>();
                    var exists = numbers.FirstOrDefault(x => x.Number == m.ToString());
                    if (exists != null)
                        continue;

                    PhoneNumber phoneNumber = new PhoneNumber();
                    phoneNumber.Number = m.ToString();
                    phoneNumbers.Add(phoneNumber);
                }
            }

            return phoneNumbers;
        }

        public List<Regex> ScrapExpressions()
        {
            List<Regex> scrapableExpressions = new List<Regex>();
            Regex regex1 = new Regex(@"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]
                |[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*
                    (?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s
                        *(?:#|x\.?|ext\.?|extension)\s*(\d+))?$");
            Regex regex2 = new Regex(@"\(?\b[0-9]{3}\)?[-. ]?[0-9]{3}[-. ]?[0-9]{4}\b");
            //Regex regex3 = new Regex(@"(?:(?:\\(?(?:0(?:0|11)\\)?[\\s-]?\\(?|\\+)44\\)?[\\s-]?(?:\\(?0\\)?[\\s-]?)?)|(?:\\(?0))(?:(?:\\d\{5\}\\)?[\\s-]?\\d\{4,5\})|(?:\\d\{4\}\\)?[\\s-]?(?:\\d\{5\}|\\d\{3\}[\\s-]?\\d\{3\}))|(?:\\d\{3\}\\)?[\\s-]?\\d\{3\}[\\s-]?\\d\{3,4\})|(?:\\d\{2\}\\)?[\\s-]?\\d\{4\}[\\s-]?\\d\{4\}))(?:[\\s-]?(?:x|ext\\.?|\\#)\\d\{3,4\})?");

            scrapableExpressions.Add(regex1);
            scrapableExpressions.Add(regex2);
            return scrapableExpressions;
        }

        public string PrettyName()
        {
            return "Phone Scrapper";
        }

        public override string ToString()
        {
            return PrettyName();
        }
    }
}
