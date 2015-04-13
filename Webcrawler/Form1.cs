using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webcrawler.Scrapper.ScrapBehavior;

namespace Webcrawler
{
    public partial class Form1 : Form
    {
        public ScrapBehavior ScrapBehavior { get; set; }
        private List<Object> ScrapValues { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private async void callCrawlerAsync(string url)
        {
            Gathers.Gather gather = new Gathers.Gather(ScrapBehavior, url);
            List<Object> values = new List<Object>();
            values = await gather.PerformScrapAsync();
        }

        private void callCrawlerSync(string url)
        {
            Gathers.Gather gather = new Gathers.Gather(ScrapBehavior, url);
            List<Object> values = new List<Object>();
            values = gather.PerformScrap();
        }

        private async void CallCrawlerAsyncWebClient(string url)
        {
            Gathers.Gather gather = new Gathers.Gather(ScrapBehavior, url);
            List<Object> values = new List<Object>();
            values = await gather.PerformScrapAsyncWebClient();
        }

        private void CallPhoneGatherOnSinglePage()
        {
        }

        private void CallPhoneGatherOnLayeredPage()
        {
        }

        private void CallHtmlGatherOnPage()
        {
        }

        private void ChainHTMLOnPhoneGather()
        {
        }
    }
}
