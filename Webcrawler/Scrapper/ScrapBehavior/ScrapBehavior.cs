using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Webcrawler.Scrapper.ScrapBehavior
{
    public interface ScrapBehavior<T>
    {
        List<T> Scrap(string text);
        Regex ScrapExpression();
    }
}
