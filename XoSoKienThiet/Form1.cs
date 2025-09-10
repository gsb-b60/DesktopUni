using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Globalization;
using System.Xml.Linq;
using System.Net.Http;
using System.IO;
using System.Diagnostics;
using XoSoKienThiet;
using System.Text.RegularExpressions;

namespace XoSoKienThiet
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> lotteryResults;
        public Form1()
        {
            InitializeComponent();
            XuatDS();
        }

        private void printPreviewControl2_Click(object sender, EventArgs e)
        {
            //https://xskt.com.vn/rss-feed/mien-nam-xsmn.rss
            //https://xskt.com.vn/rss-feed/mien-trung-xsmt.rss
            //https://xskt.com.vn/rss-feed/mien-bac-xsmb.rss
        }
        public void XuatDS()
        {
            LotterySource lotterySource = new LotterySource();
            foreach (var item in LotterySource.LotterySources)
            {
                dsXS.Nodes.Add(item.ProvinceName);
            }
        }
        private async void  button1_Click(object sender, EventArgs e)
        {

        }

        public static async Task<XDocument> ReadRss(string rssUrl)
        {
            
            using (HttpClient client = new HttpClient())
            {
                // Gửi yêu cầu GET đến URL và lấy nội dung dưới dạng chuỗi
                string rssContent = await client.GetStringAsync(rssUrl);

                XDocument doc = XDocument.Parse(rssContent);
                XElement channel = doc.Root?.Element("channel");

                XNamespace atom = "http://www.w3.org/2005/Atom";

                foreach (var item in channel.Elements("item"))
                {
                    XElement pubDateElement = item.Element("pubDate");
                    if (pubDateElement != null)
                    {
                        // Kiểm tra và chuyển đổi định dạng ngày tháng từ dd/MM/yyyy sang RFC-822
                        if (DateTime.TryParseExact(pubDateElement.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                        {
                            pubDateElement.Value = date.ToUniversalTime().ToString("R");
                        }
                        else
                        {
                            // Nếu không đúng định dạng dd/MM/yyyy, cập nhật ngày hiện tại
                            pubDateElement.Value = DateTime.UtcNow.ToString("R");
                        }
                    }

                    // Bước 3: Thêm thẻ guid nếu thiếu
                    XElement guidElement = item.Element("guid");
                    if (guidElement == null)
                    {
                        guidElement = new XElement("guid", item.Element("link")?.Value ?? Guid.NewGuid().ToString());
                        item.Add(guidElement);
                    }
                }
                if (channel.Element(atom + "link") == null)
                {
                    var link = channel.Element("link")?.Value;
                    if (!string.IsNullOrEmpty(link))
                    {
                        var selfLink = new XElement(atom + "link", new XAttribute("rel", "self"), new XAttribute("href", link), new XAttribute("type", "application/rss+xml"));
                        channel.Add(selfLink);
                    }
                }
                XElement lastBuildDateElement = channel.Element("lastBuildDate");
                if (lastBuildDateElement != null)
                {
                    lastBuildDateElement.Value = DateTime.UtcNow.ToString("R");
                }

                Console.WriteLine("=====================================================================");
                // In ra XML đã được sửa
                //Console.WriteLine(doc.ToString());


                return doc;
            }
        }

        private async void dsXS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                string provinceName = e.Node.Text;
                Debug.WriteLine("check");
                try
                {
                    string rssUrl = LotterySource.LotterySources.FirstOrDefault(s => s.ProvinceName == provinceName)?.RssUrl;
                    XDocument doc = await ReadRss(rssUrl);

                    // Tìm thẻ channel
                    XElement channel = doc.Root?.Element("channel");

                    if (channel == null)
                    {
                        Console.WriteLine("Lỗi: Không tìm thấy thẻ <channel>.");
                        return;
                    }
                    var titles = doc.Descendants("item")
                    .Select(item => item.Element("title")?.Value);

                    foreach (var title in titles)
                    {
                        TreeNode node=new TreeNode(title);
                        node.Tag = title;
                        e.Node.Nodes.Add(node);
                    }

                }
                catch (System.Xml.XmlException ex)
                {
                    Debug.WriteLine($"Lỗi khi phân tích file XML: {ex.Message}");
                }
            }
            else if (e.Node.Level == 1)
            {
                string provinceName = e.Node.Parent.Text;
                try
                {
                    string rssUrl = LotterySource.LotterySources.FirstOrDefault(s => s.ProvinceName == provinceName)?.RssUrl;
                    XDocument doc = await ReadRss(rssUrl);

                    // Tìm thẻ channel
                    XElement channel = doc.Root?.Element("channel");

                    if (channel == null)
                    {
                        Console.WriteLine("Lỗi: Không tìm thấy thẻ <channel>.");
                        return;
                    }
                    var item = doc.Descendants("item")
                    .FirstOrDefault(i => i.Element("title")?.Value == e.Node.Tag as string);

                    if (item != null)
                    {
                        string title = item.Element("title").Value;
                        string link = item.Element("link").Value;
                        string description = item.Element("description").Value;

                        richTextBox1.Text = $"{title}";
                        ktra.Text = link;


                        ktra.Tag = link;
                        var regex = new Regex(@"(?m)^(ĐB|DB|\d+):\s*([^\r\n]+)");
                        lotteryResults = new Dictionary<string, List<string>>();

                        string outPrize = "";

                        foreach (Match match in regex.Matches(description))
                        {
                            string prizeName = match.Groups[1].Value;
                            string prizeNumbersString = match.Groups[2].Value;
                            string copyP = prizeNumbersString;
                            int idx = prizeNumbersString.IndexOf(':');
                            if(idx>0)
                            {
                                prizeNumbersString= prizeNumbersString.Substring(0, idx-1).Trim();
                                outPrize=  copyP.Substring(idx-1);
                            }

                            // Tách các số nếu có nhiều số trong một giải (ví dụ giải 3, 4)
                            List<string> prizeNumbers = prizeNumbersString.Split(new char[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            lotteryResults[prizeName] = prizeNumbers;
                        }
                        lotteryResults[regex.Match(outPrize).Groups[1].Value] = regex.Match(outPrize).Groups[2].Value.Split(new char[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        foreach (var kvp in lotteryResults)
                        {
                            string prizeName = kvp.Key;
                            List<string> numbers = kvp.Value;
                            richTextBox1.AppendText($"Giải {prizeName}: {string.Join(" - ", numbers)}\n");
                        }


                    }


                }
                catch (System.Xml.XmlException ex)
                {
                    Debug.WriteLine(ex);
                }
                

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ktra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            // Check if the Tag contains a URL
            if (linkLabel.Tag is string url)
            {
                // Open the URL in the default browser
                System.Diagnostics.Process.Start(url);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string playerNumber = mtbKq.Text.Trim();
            string prize = CheckLotteryWin(playerNumber);
            if (prize != null)
                MessageBox.Show($"Bạn trúng giải {prize}! Ráng chơi tiếp xây nhà cho tui");
            else
                MessageBox.Show("Không trúng giải nào.");
        }
        private string CheckLotteryWin(string playerNumber)
        {
            foreach (var kvp in lotteryResults)
            {
                if (kvp.Value.Any(n => n.EndsWith(playerNumber)))
                    return kvp.Key;
            }
            return null;
        }
    }
}

