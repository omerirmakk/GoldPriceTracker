using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using HtmlAgilityPack;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.Net;
using System.IO;


namespace GoldPriceTracker
{
    public partial class Form1 : Form
    {
        public string html;
        public Uri url;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void btnGoldSell_Click(object sender, EventArgs e)
        {
            //GetData("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[1]/a[1]/span[3]/span[2]", lstBoxSatis);
            //GetData("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[1]/a[1]/span[2]/span[2]", lstBoxAlis);
        }*/
        private void btnGoldSell_Click_1(object sender, EventArgs e)
        {
           
            GetData("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[1]/a[1]/span[3]/span[2]", lstBoxSatis);
            if (Convert.ToInt32(lstBoxSatis.Items.Count) > 1)
            {
                lstBoxSatis.Items.Clear();
            }
        }
        private void btnGoldBuy_Click(object sender, EventArgs e)
        {
            GetData2("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[1]/a[1]/span[2]/span[2]", lstBoxAlis);
            if (Convert.ToInt32(lstBoxAlis.Items.Count) > 1)
            {
                 lstBoxAlis.Items.Clear();
                
            }
            
        }
        public void GetData(String Url, string XPath, ListBox Sonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
                
            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                lstBoxSatis.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText);
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
                
            }

        }
        public void GetData2(String Url, string XPath, ListBox Sonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                lstBoxAlis.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText);
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

        }
        public void GetDataQuarter(String Url, string XPath, ListBox Sonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                lstboxPurchase.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText);
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

        }
        public void GetDataQuarterSelling(String Url, string XPath, ListBox Sonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı url", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                lstboxSelling.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText);
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[1]/a[1]/span[3]/span[2]", lstBoxSatis);
            GetData2("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[1]/a[1]/span[2]/span[2]", lstBoxAlis);
            GetDataQuarter("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[4]/div/div/div[2]/ul[8]/li[3]", lstboxPurchase);
            GetDataQuarterSelling("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[4]/div/div/div[2]/ul[8]/li[2]", lstboxSelling);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuarterSelling_Click(object sender, EventArgs e)
        {
            GetDataQuarterSelling("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[4]/div/div/div[2]/ul[8]/li[2]", lstboxSelling);
            if (Convert.ToInt32(lstboxSelling.Items.Count) > 1)
            {
                lstboxSelling.Items.Clear();
            }
        }

        private void btnQuarterBuying_Click(object sender, EventArgs e)
        {
            GetDataQuarter("https://bigpara.hurriyet.com.tr/altin/", "//*[@id='content']/div[2]/div/div[4]/div/div/div[2]/ul[8]/li[3]", lstboxPurchase);
            if (Convert.ToInt32(lstboxPurchase.Items.Count) > 1)
            {
                lstboxPurchase.Items.Clear();
            }
        }
    }
}
