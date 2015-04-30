using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Scrapper.ScrapableItems
{
    public class PhoneNumber : Scrapable
    {
        public string Number { get; set; }

        public override string ToString()
        {
            return "Phone Number";
        }
    }
}
