using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Observer
{
    public interface Observer
    {
        void Notify(object anObject);
    }
}
