using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Scrapper.ScrapableItems
{
    public class HTMLLink : Scrapable
    {
        public string Text { get; set; }
        public string Href { get; set; }
        
        public override string ToString()
        {
            return "Html Link";
        }

        public string GetFullText()
        {
            return Href + "\n\t" + Text;
        }
    }
}
