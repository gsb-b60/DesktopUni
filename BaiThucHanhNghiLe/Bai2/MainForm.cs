using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rdnam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdnam.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nu", "Thông báo");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if(rdDo.Checked)
            {
                textBox1.BackColor = Color.Red;
            }
            else if (rdXanh.Checked)
            {
                textBox1.BackColor = Color.Green;
            }
        }
    }
}
