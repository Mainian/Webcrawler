using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webcrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            callCrawler("http://www.crossfitaoa.com/");
        }

        private async void callCrawler(string url)
        {
            string st = await Crawler.Scrapper.GetWebsiteSourceCodeAsync(url);
            foreach (char c in st)
            {
                Console.Write(c);
            }
        }
    }
}
