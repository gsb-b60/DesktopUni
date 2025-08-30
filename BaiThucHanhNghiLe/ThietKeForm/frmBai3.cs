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
    public partial class frmBai3 : Form
    {
        List<string> listTuMoi = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tu = tbTuMoi.Text;
            lbTuMoi.Items.Add(tu);
            listTuMoi.Add(tbNghia.Text);
        }

        private void lbTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbXuatNghia.Text = listTuMoi[lbTuMoi.SelectedIndex];
        }
    }
}
