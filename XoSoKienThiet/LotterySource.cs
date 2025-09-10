using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoSoKienThiet
{
    internal class LotterySource
    {

        public string ProvinceName { get; set; }
        public string RssUrl { get; set; }
        public static List<LotterySource> LotterySources = new List<LotterySource>
        {
            new LotterySource { ProvinceName = "An Giang", RssUrl = "https://xskt.com.vn/rss-feed/an-giang-xsag.rss" },
            new LotterySource { ProvinceName = "Bình Dương", RssUrl = "https://xskt.com.vn/rss-feed/binh-duong-xsbd.rss" },
            new LotterySource { ProvinceName = "Bình Định", RssUrl = "https://xskt.com.vn/rss-feed/binh-dinh-xsbdi.rss" },
            new LotterySource { ProvinceName = "Bạc Liêu", RssUrl = "https://xskt.com.vn/rss-feed/bac-lieu-xsbl.rss" },
            new LotterySource { ProvinceName = "Bình Phước", RssUrl = "https://xskt.com.vn/rss-feed/binh-phuoc-xsbp.rss" },
            new LotterySource { ProvinceName = "Bến Tre", RssUrl = "https://xskt.com.vn/rss-feed/ben-tre-xsbt.rss" },
            new LotterySource { ProvinceName = "Bình Thuận", RssUrl = "https://xskt.com.vn/rss-feed/binh-thuan-xsbth.rss" },
            new LotterySource { ProvinceName = "Cà Mau", RssUrl = "https://xskt.com.vn/rss-feed/ca-mau-xscm.rss" },
            new LotterySource { ProvinceName = "Cần Thơ", RssUrl = "https://xskt.com.vn/rss-feed/can-tho-xsct.rss" },
            new LotterySource { ProvinceName = "Đắk Lắk", RssUrl = "https://xskt.com.vn/rss-feed/dak-lak-xsdlk.rss" },
            new LotterySource { ProvinceName = "Đồng Nai", RssUrl = "https://xskt.com.vn/rss-feed/dong-nai-xsdn.rss" },
            new LotterySource { ProvinceName = "Đà Nẵng", RssUrl = "https://xskt.com.vn/rss-feed/da-nang-xsdng.rss" },
            new LotterySource { ProvinceName = "Đắk Nông", RssUrl = "https://xskt.com.vn/rss-feed/dak-nong-xsdno.rss" },
            new LotterySource { ProvinceName = "Đồng Tháp", RssUrl = "https://xskt.com.vn/rss-feed/dong-thap-xsdt.rss" },
            new LotterySource { ProvinceName = "Gia Lai", RssUrl = "https://xskt.com.vn/rss-feed/gia-lai-xsgl.rss" },
            new LotterySource { ProvinceName = "Hồ Chí Minh", RssUrl = "https://xskt.com.vn/rss-feed/ho-chi-minh-xshcm.rss" },
            new LotterySource { ProvinceName = "Hậu Giang", RssUrl = "https://xskt.com.vn/rss-feed/hau-giang-xshg.rss" },
            new LotterySource { ProvinceName = "Kiên Giang", RssUrl = "https://xskt.com.vn/rss-feed/kien-giang-xskg.rss" },
            new LotterySource { ProvinceName = "Khánh Hòa", RssUrl = "https://xskt.com.vn/rss-feed/khanh-hoa-xskh.rss" },
            new LotterySource { ProvinceName = "Kon Tum", RssUrl = "https://xskt.com.vn/rss-feed/kon-tum-xskt.rss" },
            new LotterySource { ProvinceName = "Long An", RssUrl = "https://xskt.com.vn/rss-feed/long-an-xsla.rss" },
            new LotterySource { ProvinceName = "Lâm Đồng", RssUrl = "https://xskt.com.vn/rss-feed/lam-dong-xsld.rss" },
            new LotterySource { ProvinceName = "Ninh Thuận", RssUrl = "https://xskt.com.vn/rss-feed/ninh-thuan-xsnt.rss" },
            new LotterySource { ProvinceName = "Phú Yên", RssUrl = "https://xskt.com.vn/rss-feed/phu-yen-xspy.rss" },
            new LotterySource { ProvinceName = "Quảng Bình", RssUrl = "https://xskt.com.vn/rss-feed/quang-binh-xsqb.rss" },
            new LotterySource { ProvinceName = "Quảng Ngãi", RssUrl = "https://xskt.com.vn/rss-feed/quang-ngai-xsqng.rss" },
            new LotterySource { ProvinceName = "Quảng Nam", RssUrl = "https://xskt.com.vn/rss-feed/quang-nam-xsqnm.rss" },
            new LotterySource { ProvinceName = "Quảng Trị", RssUrl = "https://xskt.com.vn/rss-feed/quang-tri-xsqt.rss" },
            new LotterySource { ProvinceName = "Sóc Trăng", RssUrl = "https://xskt.com.vn/rss-feed/soc-trang-xsst.rss" },
            new LotterySource { ProvinceName = "Tiền Giang", RssUrl = "https://xskt.com.vn/rss-feed/tien-giang-xstg.rss" },
            new LotterySource { ProvinceName = "Tây Ninh", RssUrl = "https://xskt.com.vn/rss-feed/tay-ninh-xstn.rss" },
            new LotterySource { ProvinceName = "Thừa Thiên Huế", RssUrl = "https://xskt.com.vn/rss-feed/thua-thien-hue-xstth.rss" },
            new LotterySource { ProvinceName = "Trà Vinh", RssUrl = "https://xskt.com.vn/rss-feed/tra-vinh-xstv.rss" },
            new LotterySource { ProvinceName = "Vĩnh Long", RssUrl = "https://xskt.com.vn/rss-feed/vinh-long-xsvl.rss" },
            new LotterySource { ProvinceName = "Vũng Tàu", RssUrl = "https://xskt.com.vn/rss-feed/vung-tau-xsvt.rss" },
            
        };
    }
}
