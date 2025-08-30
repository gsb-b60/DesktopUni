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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                
                lbSoNgauNhien.Items.Add(rand.Next(1, 100));
            }
        }

        private void lbSoNgauNhien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            bool kq=lbSoNgauNhien.Items.Contains(int.Parse(tbSoCanTim.Text));
            if (kq)
            {
                lblKQ.Text = "Tìm Thấy";
                lblKQ.ForeColor = Color.Red;
            }
            else
            {
                lblKQ.Text = "Không Tìm Thấy";
                lblKQ.ForeColor = Color.Blue;
            }
        }
    }
}
