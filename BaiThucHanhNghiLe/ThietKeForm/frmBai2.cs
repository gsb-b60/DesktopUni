using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void lbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            lbBo.Items.Add(lbHangHoa.SelectedItem);
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            lbBo.Items.Remove(lbBo.SelectedItems[0]);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            lblTongTien.Text = "0";
            for (int i=0; i<lbBo.Items.Count; i++)
            {
                if (lbBo.Items[i].ToString() == "Chuot")
                    lblTongTien.Text = (int.Parse(lblTongTien.Text) + 100000).ToString();
                else if (lbBo.Items[i].ToString() == "Ban phim")
                    lblTongTien.Text = (int.Parse(lblTongTien.Text) + 150000).ToString();
                else if (lbBo.Items[i].ToString() == "May in")
                    lblTongTien.Text = (int.Parse(lblTongTien.Text) + 2000000).ToString();
                else if (lbBo.Items[i].ToString() == "USB KingMax")
                    lblTongTien.Text = (int.Parse(lblTongTien.Text) + 200000).ToString();
            }
        }
    }
}
