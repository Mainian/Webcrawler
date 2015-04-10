using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webcrawler.Scrapper.ScrapableItems;
using System.Text.RegularExpressions;

namespace Webcrawler.Scrapper.ScrapBehavior
{
    public class HtmlLinkScrapper : ScrapBehavior<HTMLLink>
    {
        List<HTMLLink> Scrap(string text)
        {
            List<HTMLLink> htmlLinks = new List<HTMLLink>();

            List<Regex> expressions = ScrapExpressions();

            MatchCollection m1 = Regex.Matches(text, expressions[0].ToString(), RegexOptions.Singleline);

            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                HTMLLink newLink = new HTMLLink();

                Match m2 = Regex.Match(value, expressions[1].ToString(), RegexOptions.Singleline);
                if (m2.Success)
                    newLink.Href = m2.Groups[1].Value;

                string htmlText = Regex.Replace(value, expressions[2].ToString(), "", RegexOptions.Singleline);

                newLink.Text = htmlText;

                htmlLinks.Add(newLink);
            }

            return htmlLinks;
        }

        List<Regex> ScrapExpressions()
        {
            List<Regex> ScrapExpressions = new List<Regex>();
            ScrapExpressions.Add(new Regex(@"(<a.*?>.*?</a>)"));
            ScrapExpressions.Add(new Regex(@"href=\""(.*?)\"""));
            ScrapExpressions.Add(new Regex(@"\s*<.*?>\s*"));

            return ScrapExpressions;
        }
    }
}
