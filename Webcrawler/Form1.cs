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
        ScrapBehavior phoneScraper = new PhoneScraper();
        ScrapBehavior htmlLinkScraper = new HtmlLinkScraper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_ScrapBehavior.Items.Add(phoneScraper);
            comboBox_ScrapBehavior.Items.Add(htmlLinkScraper);

            comboBox_ScrapStyle.Items.Add("Sync");
            comboBox_ScrapStyle.Items.Add("Async");
            comboBox_ScrapStyle.Items.Add("Async Web Socket");
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

            foreach(Scrapper.ScrapableItems.PhoneNumber str in values)
                Console.Out.WriteLine(str.Number);
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

        private void button_Scrap_Click(object sender, EventArgs e)
        {
            if (comboBox_ScrapStyle.Text == "" || comboBox_ScrapBehavior.Text == "" || textBox_URL.Text == "" || textBox_OutputLocation.Text == "")
                return;

            ScrapBehavior = (ScrapBehavior)comboBox_ScrapBehavior.SelectedItem;

            switch (comboBox_ScrapStyle.Text)
            {
                case "Sync":
                    callCrawlerSync(textBox_URL.Text.ToString());
                    break;
                case "Async": 
                    callCrawlerAsync(textBox_URL.Text.ToString());
                    break;
                case "Async Web Socket":
                    CallCrawlerAsyncWebClient(textBox_URL.Text.ToString());
                    break;
                default: return;
            }
        }


    }
}
